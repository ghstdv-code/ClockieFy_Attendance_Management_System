using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows.Media;
using ClockiFyAMS.Database;
using System.Text.Json;

namespace ClockiFyAMS.Modals
{
    /// <summary>
    /// Interaction logic for Person.xaml
    /// </summary>
    public partial class Person : UserControl
    {
        public enum Mode
        {
            SAVE,
            UPDATE
        }
        MainWindow root;
        public Person(MainWindow root)
        {
            InitializeComponent();
            this.root = root;
        }

        public Mode SetMode { get; set; }

        #region Dependecy Property



        public string CommandButtonText
        {
            get { return (string)GetValue(CommandButtonTextProperty); }
            set { SetValue(CommandButtonTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CommandButtonText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandButtonTextProperty =
            DependencyProperty.Register("CommandButtonText", typeof(string), typeof(Person));



        public BitmapImage qrcode
        {
            get { return (BitmapImage)GetValue(qrcodeProperty); }
            set { SetValue(qrcodeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for qrcode.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty qrcodeProperty =
            DependencyProperty.Register("qrcode", typeof(BitmapImage), typeof(Person));



        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(Person));



        public string PID
        {
            get { return (string)GetValue(PIDProperty); }
            set { SetValue(PIDProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PID.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PIDProperty =
            DependencyProperty.Register("PID", typeof(string), typeof(Person));



        //public string PHashKey
        //{
        //    get { return (string)GetValue(PHashKeyProperty); }
        //    set { SetValue(PHashKeyProperty, value); }
        //}

        // Using a DependencyProperty as the backing store for PHashKey.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PHashKeyProperty =
            DependencyProperty.Register("PHashKey", typeof(string), typeof(Person));




        public string PName
        {
            get { return (string)GetValue(PNameProperty); }
            set { SetValue(PNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PNameProperty =
            DependencyProperty.Register("PName", typeof(string), typeof(Person));



        public string PJobDescription
        {
            get { return (string)GetValue(PJobDescriptionProperty); }
            set { SetValue(PJobDescriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PJobDescription.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PJobDescriptionProperty =
            DependencyProperty.Register("PJobDescription", typeof(string), typeof(Person));




        public int PGender
        {
            get { return (int)GetValue(PGenderProperty); }
            set { SetValue(PGenderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PGender.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PGenderProperty =
            DependencyProperty.Register("PGender", typeof(int), typeof(Person));




        public string PAddress
        {
            get { return (string)GetValue(PAddressProperty); }
            set { SetValue(PAddressProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PAddress.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PAddressProperty =
            DependencyProperty.Register("PAddress", typeof(string), typeof(Person));

        #endregion

        bool Valid()
        {
            var tbxs = new List<TextBox>();
            tbxs.Add(tb_FullName);
            tbxs.Add(tb_JobDesc);
            tbxs.Add(tb_Addresss);

            int counter = 0;
            for (int i = tbxs.Count - 1; i >= 0; i--)
            {
                if (string.IsNullOrEmpty(tbxs[i].Text))
                {
                    counter++;
                    lb_Error.Text = $"Please input valid {tbxs[i].Tag}";
                    lb_Error.Background = new SolidColorBrush(Color.FromRgb(244, 77, 93));
                    lb_Error.Visibility = Visibility.Visible;
                    tbxs[i].Focus();
                }
            }

            if (counter <= 0)
            {
                return true;
            }

            return false;
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            SetDefaults();
        }


        void EncodePNG(Image img)
        {
            if (img != null)
            {
                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapSource)img.Source));

                using (FileStream fs = new FileStream(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/DecodedImages/" + uid.Text + ".png", FileMode.Create))
                {
                    encoder.Save(fs);
                }

            }
        }

        private void bt_AddToRecord_Click(object sender, RoutedEventArgs e)
        {
         

            if (Valid())
            {
                config.WorkerObj = new Workers
                {
                    UID = uid.Text.Trim(),
                    FullName = tb_FullName.Text.Trim(),
                    JobDescription = tb_JobDesc.Text.Trim(),
                    Gender = cb_Gender.Text.Trim(),
                    Address = tb_Addresss.Text.Trim()
                };

                if (SetMode == Mode.SAVE)
                {

                    new Create().AddPerson();

                    EncodePNG(genBox);

                    #region Renew UID
                    bool b = false;
                    var guid = Guid.NewGuid();
                    config.key = guid.ToString();
                    while (true)
                    {
                        if (new Read().CheckID() <= 0)
                        {
                            b = true;
                            break;
                        }
                    }

                    if (b)
                    {
                        uid.Text = Guid.NewGuid().ToString();
                        genBox.Source = Helper.QRGenerator(uid.Text);
                    }

                    #endregion


                    lb_Error.Text = $"Record Successfully Added";
                
                }
                else
                {
                    new Update().UpdatePerson();
                    lb_Error.Text = $"Record Successfully Updated";
                    root.RootDialogHost.IsOpen = false;
                }

                SetDefaults();
                lb_Error.Background = new SolidColorBrush(Color.FromRgb(49, 166, 92));
                lb_Error.Visibility = Visibility.Visible;
                tb_FullName.Focus();
            }
        }

        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            lb_Error.Visibility = Visibility.Hidden;
        }

        private void SetDefaults()
        {
            tb_FullName.Clear();
            tb_Addresss.Clear();
            tb_JobDesc.Clear();
            cb_Gender.SelectedIndex = 0;
        }

        private void cb_Gender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lb_Error.Visibility = Visibility.Hidden;
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            root.RootDialogHost.IsOpen = false;
        }
    }
}
