using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;

namespace UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
                // تعريف البيانات (SeriesCollection)
                pieChart1.Series = new SeriesCollection
    {
        new PieSeries
        {
            Title = "مكتملة",
            Values = new ChartValues<double> { 70 }, // نسبة الإنجاز
            Fill = System.Windows.Media.Brushes.MediumSeaGreen,
            DataLabels = true
        },
        new PieSeries
        {
            Title = "متبقية",
            Values = new ChartValues<double> { 30 }, // النسبة المتبقية
            DataLabels = true
        }
    };

                // تحسين المظهر
                pieChart1.LegendLocation = LegendLocation.Bottom;
            
        }
    }
}
