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

namespace ClockiFyAMS.Modals
{
    /// <summary>
    /// Interaction logic for DialogModal.xaml
    /// </summary>
    public partial class DialogModal : UserControl
    {
        public DialogModal(string message, PackIconKind mdkind, MessageType mtype)
        {
            InitializeComponent();
            ConfigureLayout(mtype);
            tbMessage.Text = message;
            mdIcon.Kind = mdkind;
        }

        private void ConfigureLayout(MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.Warning:
                    mdIcon.Foreground = new SolidColorBrush(Color.FromRgb(249, 168, 37));
                    //cmd1.Visibility = Visibility.Hidden;
                    //Grid.SetColumnSpan(cmd2, 3);
                    cmd1.Content = "Yes";
                    cmd2.Content = "No";
                    break;

                case MessageType.Info:
                    mdIcon.Foreground = new SolidColorBrush(Color.FromRgb(61, 90, 254));
                    cmd2.Visibility = Visibility.Hidden;
                    Grid.SetColumnSpan(cmd1, 3);
                    cmd1.Content = "Yes";
                    cmd2.Content = "No";
                    break;
            }


        }
    }
}
