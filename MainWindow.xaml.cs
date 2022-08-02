using ClockiFyAMS.Modals;
using LiveCharts;
using LiveCharts.Wpf;
using MaterialDesignThemes.Wpf;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ClockiFyAMS.Database;

namespace ClockiFyAMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Series 1",
                    Values = new ChartValues<double> { 4, 6, 5, 2 ,4 }
                },
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> { 6, 7, 3, 4 ,6 },
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "Series 3",
                    Values = new ChartValues<double> { 4,2,7,2,7 },
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15
                }
            };

            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" };
            YFormatter = value => value.ToString("C");

            //modifying the series collection will animate and update the chart
            SeriesCollection.Add(new LineSeries
            {
                Title = "Series 4",
                Values = new ChartValues<double> { 5, 3, 2, 4 },
                LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 50,
                PointForeground = Brushes.Gray
            });

            //modifying any series values will also animate and update the chart
            SeriesCollection[3].Values.Add(5d);

            PointLabel = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);


            DataContext = this;


        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        public Func<ChartPoint, string> PointLabel { get; set; }

        private void Chart_OnDataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartpoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartpoint.SeriesView;
            selectedSeries.PushOut = 8;
        }

        private async void btnLogout_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var dialogBox
                           = new DialogModal(
                           "Are you sure you want to logout?",
                           PackIconKind.HelpRhombusOutline,
                           MessageType.Warning);

            object result = await DialogHost.Show(dialogBox, "RootDialogHostId");
            if (!(result is null))
            {
                if ((string)result == "cmd1execute")
                {
                    Hide();
                    var login = new LogIn();
                    login.Show();
                }
                
            }
        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            root_Panel.Children.Clear();
            var dboard_Modal = new Modal_Dashboard(this);
            root_Panel.Children.Add(dboard_Modal);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            root_Panel.Children.Clear();
            var dboard_Modal = new Modal_Dashboard(this);
            root_Panel.Children.Add(dboard_Modal);

        }

        private async void btn_Administration_Click(object sender, RoutedEventArgs e)
        {
            var dialogBox = new Administration(this)
            {
                Username = config.AccountObj.user
            };

            object result = await DialogHost.Show(dialogBox, "RootDialogHostId");
            if (!(result is null))
            {
                if ((string)result == "cmd1execute") Application.Current.Shutdown();
            }
        }

        private void btn_Emlist_Click(object sender, RoutedEventArgs e)
        {

            root_Panel.Children.Clear();
            var obj = new EmployeeList(this);
            root_Panel.Children.Add(obj);
            
        }

        private void btn_Records_Click(object sender, RoutedEventArgs e)
        {
            root_Panel.Children.Clear();
            var obj = new Records(this);
            root_Panel.Children.Add(obj);
        }
    }
}
