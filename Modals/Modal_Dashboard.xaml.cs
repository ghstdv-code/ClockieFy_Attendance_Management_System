using LiveCharts;
using LiveCharts.Wpf;
using MaterialDesignThemes.Wpf;
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
using ClockiFyAMS.Database;
using LiveCharts.Helpers;

namespace ClockiFyAMS.Modals
{
    public class attItems
    {
        
    }
    /// <summary>
    /// Interaction logic for Modal_Dashboard.xaml
    /// </summary>
    public partial class Modal_Dashboard : UserControl
    {
        public int Present { get; set; }
        public int Late { get; set; }
        public int Absent { get; set; }
        public int Total { get; set; }

        private MainWindow root;
        public Modal_Dashboard(MainWindow root)
        {
            InitializeComponent();
            var at = new Read().AttendanceReportPreviewsDay();
            Present = at[0];
            Late = at[1];

            var total = new Read().TotalCount();
            Total = total;

            Absent = total - (at[0] + at[1]);

            load6Days();


            var graphSeries = new Read().View7Days();

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Excellent Worker",
                    Values = new ChartValues<int> { 
                        graphSeries[0].GoodEmployee,
                        graphSeries[1].GoodEmployee,
                        graphSeries[2].GoodEmployee,
                        graphSeries[3].GoodEmployee
                    }
                },
                new LineSeries
                {
                    Title = "Poor Worker",
                    Values = new ChartValues<int> {
                        graphSeries[0].BadEmployee,
                        graphSeries[1].BadEmployee,
                        graphSeries[2].BadEmployee,
                        graphSeries[3].BadEmployee
                    },
                    PointGeometry = null
                },
            };

            Labels = new[] { "Week 1", "Week 2", "Week 3", "Week 4" };
            YFormatter = value => value.ToString();

            //modifying any series values will also animate and update the chart

            PointLabel = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);


            DataContext = this;
            this.root = root;
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
                if ((string)result == "cmd1execute") Application.Current.Shutdown();
            }
        }


        void load6Days()
        {
            ldate1.Title = DateTime.Now.AddDays(-1).ToShortDateString();
            ldate2.Title = DateTime.Now.AddDays(-2).ToShortDateString();
            ldate3.Title = DateTime.Now.AddDays(-3).ToShortDateString();
            ldate4.Title = DateTime.Now.AddDays(-4).ToShortDateString();
            ldate5.Title = DateTime.Now.AddDays(-5).ToShortDateString();
            ldate6.Title = DateTime.Now.AddDays(-6).ToShortDateString();

            var a = new Read().View6Days();
            ldate1.Values = new ChartValues<int> { a[0] };
            ldate2.Values = new ChartValues<int> { a[1] };
            ldate3.Values = new ChartValues<int> { a[2] };
            ldate4.Values = new ChartValues<int> { a[3] };
            ldate5.Values = new ChartValues<int> { a[4] };
            ldate6.Values = new ChartValues<int> { a[5] };

        }

    }

}

