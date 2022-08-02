using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;
using QRScanner.Model;
using ZXing;

namespace QRScanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<QRDictionary> decodedQr = new List<QRDictionary>();
        bool mode = false;

        private VideoCaptureDevice finalFrame = null;
        public MainWindow()
        {
            InitializeComponent();
            tbkStatus.Text = "Not Ready";
            dgvPresentEnt.Items.Add(new Employees
            {
                EmployeeID = "AD1231214",
                EmployeeName = "Raul",
                EmployeeDescription = "Helper",
                Category = "In",
                TimeInOut = DateTime.Now
            }); 
        }
        private  void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                BitmapImage bitmapImage;
                using (var bitmap = (Bitmap)eventArgs.Frame.Clone())
                {
                    bitmapImage = bitmap.ToBitmapImage();
                }
                bitmapImage.Freeze();

                 Task.Delay(3000).ContinueWith(_ =>
                {
                    BarcodeReader barcodeReader = new BarcodeReader() { AutoRotate = true };
                    Result result = barcodeReader.Decode(bitmapImage);

                    if (result != null)
                    {
                        Dispatcher.BeginInvoke(new ThreadStart(delegate
                        {

                            if (!decodedQr.Any(qrs => qrs.ID == result.ToString() && qrs.Mode == (mode ? "IN" : "OUT")))
                            {
                                //dgvPresentEnt.Items.Add(new Employees
                                //{
                                //    EmployeeID = result.ToString(),
                                //    EmployeeName = "Raul",
                                //    EmployeeDescription = "Helper",
                                //    Category = mode ? "IN" : "OUT",
                                //    TimeInOut = DateTime.Now
                                //});
                                //decodedQr.Add(new QRDictionary() { ID = result.ToString(), Mode = mode ? "IN" : "OUT" });

                            }


                            else
                            {

                                tbkStatus.Text = "ID Already in the List";
                            }


                            Task.Delay(3000).ContinueWith(_t =>
                            {
                                tbkStatus.Text = "Ready";
                            });


                        }));
                    }
                });


                
                Dispatcher.BeginInvoke(new ThreadStart(delegate { imgView.Source = bitmapImage; }));
            }
            catch { }
            
        }

        private void btnPowerOn_Click(object sender, RoutedEventArgs e)
        {
            tbkStatus.Text = "Prepairing";
            finalFrame = new VideoCaptureDevice((new FilterInfoCollection(FilterCategory.VideoInputDevice))[0].MonikerString);
            finalFrame.NewFrame += FinalFrame_NewFrame;
            finalFrame.Start();
        
            Task.Delay(4000).ContinueWith(_ => {
                Dispatcher.BeginInvoke(new ThreadStart(delegate { tbkStatus.Text = "Ready"; }));
            });
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (finalFrame != null)
                finalFrame.Stop();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            imgView.Source = null;
            if (finalFrame != null)
                finalFrame.Stop();

            foreach (QRDictionary qrd in decodedQr)
                MessageBox.Show($"{qrd.ID} {qrd.Mode}");
        }

        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            var rb = (RadioButton)sender;
            mode = rb.Name == nameof(rbIn) ? true : false;
        }
    }
}
