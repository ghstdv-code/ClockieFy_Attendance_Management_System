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
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;
using ClockiFyAMS.Database;

namespace ClockiFyAMS
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_uname.Text) || string.IsNullOrEmpty(tb_pw.Password))
            {
                lbl_status.Text = "Please fill-up required fields";
                main_grid.RowDefinitions[0].Height = new GridLength(60, GridUnitType.Pixel);
                this.Height = 350;
            }

            else
            {
                config.AccountObj = new Modals.Account();
                config.AccountObj.user = tb_uname.Text;
                config.AccountObj.passwd = tb_pw.Password;
                
                var acctFound = new Read().LogIn();


                int hasFound = new Read().LogIn().Count;
                if (hasFound <= 0) 
                {
                    lbl_status.Text = "Username or Password was incorrect!";
                    main_grid.RowDefinitions[0].Height = new GridLength(60, GridUnitType.Pixel);
                    this.Height = 350;
                }
                else
                {
                    config.AccountObj.id = acctFound[0].id;
                    config.AccountObj.user = acctFound[0].user;
                    config.AccountObj.passwd = acctFound[0].passwd;
                    var main = new MainWindow();
                    main.Show();
                    tb_uname.Clear();
                    tb_pw.Clear();
                    Hide();
                }
            }
        }

        private void tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            main_grid.RowDefinitions[0].Height = new GridLength(40, GridUnitType.Pixel);
            this.Height = 320;
        }

        private void tb_pw_PasswordChanged(object sender, RoutedEventArgs e)
        {
            main_grid.RowDefinitions[0].Height = new GridLength(40, GridUnitType.Pixel);
            this.Height = 320;
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
