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
using System.Windows.Media;

namespace UI
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mangDataSet.members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.mangDataSet.members);


            //-----------------------------------------------------------



            // إعداد البيانات
            pieChart2.Series = new SeriesCollection
{
    new PieSeries
    {
        Title = "Completed",
        Values = new ChartValues<double> { 115 },
        Fill = System.Windows.Media.Brushes.LimeGreen, // اللون الأخضر
        PushOut = 0 // المسافة بين القطاعات
    },
    new PieSeries
    {
        Title = "Remaining",
        Values = new ChartValues<double> { 42 },
        Fill = System.Windows.Media.Brushes.Gray, // اللون الرمادي
        PushOut = 0
    }
};

            // --- السر هنا لجعلها بشكل Donut ---
            pieChart2.InnerRadius = 80; // كلما زاد الرقم، زاد تجويف الدائرة (جرب 50 إلى 80)

            // إعداد مكان التوضيح (Legend) في الأسفل كما بالصورة
            pieChart2.LegendLocation = LegendLocation.Bottom;


            //------------------------------------


           
           

           
            {
                // 1. إعداد البيانات المنجزة (اللون الأزرق)
                var completedSeries = new StackedColumnSeries
                {
                    Title = "Completed",
                    Values = new ChartValues<int> { 23, 22, 22, 21, 12, 10 },
                    StackMode = StackMode.Values, // هذا السطر يجعلها تتراكم فوق بعضها
                    Fill = (SolidColorBrush)new BrushConverter().ConvertFromString("#2980B9"), // لون أزرق عصري
                    DataLabels = true // لإظهار الأرقام داخل الأعمدة كما في الصورة
                };

                // 2. إعداد البيانات المتبقية (اللون البرتقالي)
                var remainingSeries = new StackedColumnSeries
                {
                    Title = "Remaining",
                    Values = new ChartValues<int> { 6, 6, 10, 9, 5, 5 },
                    StackMode = StackMode.Values,
                    Fill = (SolidColorBrush)new BrushConverter().ConvertFromString("#E67E22"), // لون برتقالي
                    DataLabels = true
                };

                // إضافة البيانات للرسم البياني
                cartesianChart1.Series = new SeriesCollection { completedSeries, remainingSeries };

                // 3. إعداد المحور الأفقي (أسماء الأعضاء)
                cartesianChart1.AxisX.Add(new Axis
                {
                    Title = "Team Members",
                    Labels = new[] { "Ahmed", "Sara", "Ali", "Mona", "Omar", "Youssef" },
                    Separator = new Separator { Step = 1, IsEnabled = false } // إخفاء الخطوط الشبكية الطولية
                });

                // 4. إعداد المحور الرأسي
                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "Number of Tasks",
                    LabelFormatter = value => value.ToString(),
                    MinValue = 0
                });

                // إظهار وسائل الإيضاح في الأسفل
                cartesianChart1.LegendLocation = LegendLocation.Bottom;
            }
        }

        
    }
}
