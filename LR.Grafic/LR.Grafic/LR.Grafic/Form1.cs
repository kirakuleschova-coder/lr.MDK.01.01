using GafLip;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR.Grafic
{
    public partial class MyForm : Form
    {
        private SalonLibrary.Statistics salonStats;

        private SalonLibrary.Service currentService;

        public MyForm()
        {
            InitializeComponent();

            salonStats = new SalonLibrary.Statistics();

            salonStats.LoadTestData();

            FillServicesList();

            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;

            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }
        }

        private void FillServicesList()
        {
            listBox1.Items.Clear();

            foreach (var service in salonStats.GetAllServices())
            {
                listBox1.Items.Add(service.Name);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            string selectedName = listBox1.SelectedItem.ToString();

            currentService = salonStats.GetServiceByName(selectedName);

            if (currentService != null)
            {
                BuildLineChart();  
                BuildPieChart();   
            }
        }

        private void BuildLineChart()
        {
            if (currentService == null) return;

            cartesianChart1.Series = new SeriesCollection();

            cartesianChart1.Series.Add(new LineSeries
            {
                Title = currentService.Name,

                Values = new ChartValues<int>(currentService.DailyCount),

                PointGeometrySize = 15,

                DataLabels = true,

                Fill = System.Windows.Media.Brushes.Transparent
            });

            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Дни",

                Labels = new[] { "1", "2", "3", "4", "5", "6", "7" },

                LabelsRotation = 0,

                Separator = new Separator { Step = 1 }
            });

            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Количество оказаний",

                MinValue = 0,

                MaxValue = 20,

                LabelFormatter = value => value.ToString("N0")
            });
        }

        private void BuildPieChart()
        {
            var allServices = salonStats.GetAllServices();

            decimal totalRevenue = salonStats.GetTotalRevenue();

            if (totalRevenue == 0) return;

            pieChart1.Series = new SeriesCollection();

            pieChart1.LegendLocation = LegendLocation.Bottom;

            foreach (var service in allServices)
            {
                double percentage = (double)(service.TotalRevenue / totalRevenue) * 100;

                pieChart1.Series.Add(new PieSeries
                {
                    Title = service.Name,

                    Values = new ChartValues<double> { percentage },

                    DataLabels = true,
                    LabelPoint = point => $"{service.Name}: {point.Y:F1}%",

                    PushOut = 0
                });
            }
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
        }
    }
}
