using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using LiveCharts.Wpf;
using LiveCharts;

namespace UI
{
    public static class Database_Selects
    {
        private static string connectionString = @"Data Source=DESKTOP-GHA82A2\HUSINSERVER;Initial Catalog = mang; Integrated Security = True";

        public static void DisplayStatusSummary(DataGridView dgv, int projectId)
        {
            // الاستعلام الذي طلبته مع تسمية الأعمدة بشكل احترافي للعرض
            string query = @"
               SELECT 
    tk.tk_name AS [Task Name],
    m.m_name AS [Assigned To],
    tk.status AS [Current Status],
    p.project_name AS [Project]
FROM tasks tk
JOIN members m ON tk.assigned_to = m.m_id
JOIN projects p ON tk.project_id = p.project_id
WHERE p.project_id = 1
ORDER BY tk.status DESC;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@projectId", projectId);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // 1. ربط البيانات بالجدول
                    dgv.DataSource = dt;

                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء جلب البيانات: " + ex.Message);
                }


            }


        }
        public static void LoadTeamProductivityChart(LiveCharts.WinForms.CartesianChart chart, int projectId)
        {
            string query = @"
        SELECT assigned_to, 
               SUM(CASE WHEN status = 'Completed' THEN 1 ELSE 0 END) as Done,
               SUM(CASE WHEN status != 'Completed' THEN 1 ELSE 0 END) as Pending
        FROM tasks WHERE project_id = 1 GROUP BY assigned_to";

            ChartValues<int> completedValues = new ChartValues<int>();
            ChartValues<int> remainingValues = new ChartValues<int>();
            List<string> labels = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    labels.Add(reader["assigned_to"].ToString());
                    completedValues.Add(Convert.ToInt32(reader["Done"]));
                    remainingValues.Add(Convert.ToInt32(reader["Pending"]));
                }
            }

            // إعداد السلاسل البيانية (Series)
            chart.Series = new SeriesCollection
    {
        new StackedColumnSeries
        {
            Title = "Completed",
            Values = completedValues,
            StackMode = StackMode.Values,
            Fill = System.Windows.Media.Brushes.DeepSkyBlue // نفس لون الصورة
        },
        new StackedColumnSeries
        {
            Title = "Remaining",
            Values = remainingValues,
            StackMode = StackMode.Values,
            Fill = System.Windows.Media.Brushes.Orange // نفس لون الصورة
        }
    };

            // إعداد المحاور
            chart.AxisX.Clear();
            chart.AxisX.Add(new Axis { Labels = labels, Separator = new Separator { Step = 1 } });
        }



        public static void LoadProjectProgressDonut(LiveCharts.WinForms.PieChart chart, int projectId)
        {
            string query = @"
        SELECT 
            SUM(CASE WHEN status = 'Completed' THEN 1 ELSE 0 END) as Done,
            SUM(CASE WHEN status != 'Completed' THEN 1 ELSE 0 END) as Pending
        FROM tasks WHERE project_id = @projectId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int completed = reader["Done"] != DBNull.Value ? Convert.ToInt32(reader["Done"]) : 0;
                    int remaining = reader["Pending"] != DBNull.Value ? Convert.ToInt32(reader["Pending"]) : 0;

                    // إعداد بيانات الدائرة
                    chart.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Completed",
                    Values = new ChartValues<int> { completed },
                    Fill = System.Windows.Media.Brushes.LimeGreen, // اللون الأخضر كما في صورتك
                    
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Remaining",
                    Values = new ChartValues<int> { remaining },
                    Fill = System.Windows.Media.Brushes.DimGray, // اللون الرمادي للجزء المتبقي
                   
                    DataLabels = true
                }
            };
                }
            }

            // إعدادات جمالية للمخطط
            chart.LegendLocation = LegendLocation.Bottom;
            
        }

       

public static void RefreshDashboardStats(int projectId, Label lblTotalTasks, Label lblMembers, Label lblCompleted, Label lblRemaining)
    {
        // استعلام يجلب كافة الإحصائيات للمشروع المحدد
        string query = @"
        SELECT 
            (SELECT COUNT(*) FROM tasks WHERE project_id = 1) AS TotalTasks,
            (SELECT COUNT(DISTINCT assigned_to) FROM tasks WHERE project_id = 1) AS TotalMembers,
            (SELECT COUNT(*) FROM tasks WHERE project_id = 1 AND status = 'Completed') AS Completed,
            (SELECT COUNT(*) FROM tasks WHERE project_id = 1 AND status != 'Completed') AS Remaining";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("1", projectId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // تحديث الـ Labels بالأرقام الحقيقية من قاعدة البيانات
                    lblTotalTasks.Text = reader["TotalTasks"].ToString();
                    lblMembers.Text = reader["TotalMembers"].ToString();
                    lblCompleted.Text = reader["Completed"].ToString();
                    lblRemaining.Text = reader["Remaining"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحديث البطاقات: " + ex.Message);
            }
        }
    }

}



}
