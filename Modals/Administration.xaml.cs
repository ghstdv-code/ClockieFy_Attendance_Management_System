using System;
using System.Collections.Generic;
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
using MaterialDesignThemes.Wpf;
using ClockiFyAMS.Database;

namespace ClockiFyAMS.Modals
{
    /// <summary>
    /// Interaction logic for Administration.xaml
    /// </summary>
    public partial class Administration : UserControl
    {


        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Username.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register("Username", typeof(string), typeof(Administration));



        private MainWindow root;
        public Administration(MainWindow root)
        {
            InitializeComponent();
            this.root = root;
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            root.RootDialogHost.IsOpen = false;
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            
            if (string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(curpw.Password) || string.IsNullOrEmpty(npw.Password) || string.IsNullOrEmpty(rnpw.Password))
            {
                lbl_status.Visibility = Visibility.Visible;
                lbl_status.Text = "Please fill-up empty fields";
            }

            else
            {
                if (!npw.Password.Equals(rnpw.Password))
                {
                    lbl_status.Visibility = Visibility.Visible;
                    lbl_status.Text = "New password mismatch!";
                }

                else
                {
                    if (curpw.Password == config.AccountObj.passwd && username.Text == config.AccountObj.user)
                    {
                        config.AccountObj.passwd = rnpw.Password;
                        new Update().UpdateAccount();
                        root.RootDialogHost.IsOpen = false;
                    }

                    else
                    {
                        lbl_status.Visibility = Visibility.Visible;
                        lbl_status.Text = "Old credential mismatch!";
                    }

                }
            }
        }

        private void pw_PasswordChanged(object sender, RoutedEventArgs e)
        {
            lbl_status.Visibility = Visibility.Hidden;
        }
    }
}
