using ClockiFyAMS.Database;
using MaterialDesignThemes.Wpf;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace ClockiFyAMS.Modals
{
    /// <summary>
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : UserControl
    {
        private MainWindow root;
        public EmployeeList(MainWindow root)
        {
            InitializeComponent();
            this.root = root;

            LoadData();
        }

        void LoadData()
        {
            dgvPresentEnt.Items.Clear();
            DataTable dt = new Read().LoadData();
            if(dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    var wr = new Workers {
                        UID = (string)dr["UID"],
                        FullName = (string)dr["FullName"],
                        JobDescription = (string)dr["JobDescription"],
                        Gender = (string)dr["Gender"] == "True" ? "MALE" : "FEMALE",
                        Address = (string)dr["Address"],
                        Performance = (string)dr["Performance"]
                    };

                    dgvPresentEnt.Items.Add(wr);
                }
            }
        }

        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {
            config.key = tbx_Search.Text;
            LoadData();
        }

        private async void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            bool b = false;
            var guid = Guid.NewGuid();
            config.key = guid.ToString();
            while (true){
                if(new Read().CheckID() <= 0)
                {
                    b = true;
                    break;
                }
            }

            if (b)
            {
                
                var dialogBox = new Person(this.root)
                {
                    Title = "Add Employee",
                    qrcode = Helper.QRGenerator(guid.ToString()),
                    PID = guid.ToString(),
                    SetMode = Person.Mode.SAVE,
                    CommandButtonText = "ADD RECORD"
                   

                };

                await DialogHost.Show(dialogBox, "RootDialogHostId");
            }
           
        }

        private async void btn_View_Click(object sender, RoutedEventArgs e)
        {
            Workers wr = (Workers)dgvPresentEnt.SelectedItem;
            var dialogBox = new Person(this.root)
            {
                Title = "Update Employee",
                qrcode = Helper.QRGenerator(wr.UID),
                PID = wr.UID,
                SetMode = Person.Mode.UPDATE,
                CommandButtonText = "UPDATE RECORD",
                PName = wr.FullName,
                PJobDescription = wr.JobDescription,
                PGender = wr.Gender == "MALE" ? 0 : 1,
                PAddress = wr.Address
            };

            await DialogHost.Show(dialogBox, "RootDialogHostId");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Workers wr = (Workers)dgvPresentEnt.SelectedItem;
            config.WorkerObj = wr;
            new Delete().RemovePerson();
            dgvPresentEnt.Items.Remove(dgvPresentEnt.SelectedItem);
       }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
