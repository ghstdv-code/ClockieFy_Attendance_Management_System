using ClockiFyAMS.Database;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClockiFyAMS.Modals
{
    /// <summary>
    /// Interaction logic for Records.xaml
    /// </summary>
    public partial class Records : UserControl
    {
        private MainWindow root;
        public Records(MainWindow root)
        {
            InitializeComponent();
            this.root = root;
            dtp.Text = DateTime.Now.ToString("yyyy-MM-dd");
            LoadData();
        }

        private async void launchQr_Click(object sender, RoutedEventArgs e)
        {

            var dialogBox
                          = new DialogModal(
                          "Function Under Construction",
                          PackIconKind.AccountHardHat,
                          MessageType.Info);

            object result = await DialogHost.Show(dialogBox, "RootDialogHostId");
            if (!(result is null))
            {
                //if ((string)result == "cmd1execute") Application.Current.Shutdown();
            }
            //process.StartInfo.FileName = @"C:\Python310\python.exe";
            //process.StartInfo.RedirectStandardInput = true;

            //process.StartInfo.CreateNoWindow = false;
            //process.StartInfo.UseShellExecute = false;
            //process.StartInfo.Arguments = AppDomain.CurrentDomain.BaseDirectory + @"QRScanner\main.py";
            //process.Start();
        }

        void launchQR()
        {

            Process process = new Process();
            process.StartInfo.FileName = "python.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.Arguments = AppDomain.CurrentDomain.BaseDirectory + @"QRScanner\main.py";
            process.Start();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var wr = (Attendance)dgvPresentEnt.SelectedItem;
            config.AttObj = wr;
            new Delete().RemoveRecord();
            dgvPresentEnt.Items.Remove(dgvPresentEnt.SelectedItem);
        }
        void LoadData()
        {
            dgvPresentEnt.Items.Clear();
            DataTable dt = new Read().LoadLogs();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    var att = new Attendance
                    {
                        UID = (string)dr["UID"],
                        FullName = (string)dr["FullName"],
                        AttDate = (DateTime.Parse((string)dr["Date"])).ToString("yyyy-MM-dd"),
                        TimeIn = (string)dr["TimeIn"],
                        Timeout = (string)dr["TimeOut"],
                        TImeWorked = (string)dr["TimeWorked"]
                    };

                    dgvPresentEnt.Items.Add(att);
                }
            }
        }

        private void filter_Click(object sender, RoutedEventArgs e)
        {
            config.key = DateTime.Parse(dtp.Text).ToString("yyyy-MM-dd");
            LoadData();
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }

}
