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
using System.Data.SqlClient;


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

            DataGridView_Design.ApplyDarkTheme(dgvstatus);

            //--------------------------------------------------

            
            Database_Selects.DisplayStatusSummary(dgvstatus, 2);
            // تجعل الأعمدة تتمدد تلقائياً لتناسب حجم أطول جملة في كل عمود
            dgvstatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // إذا كنت تريد للعمود الأخير أن يملأ باقي مساحة الجدول تماماً
            dgvstatus.Columns[dgvstatus.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //--------------------------------------------------


            Database_Selects.LoadTeamProductivityChart(cartesianChart1, 1);
            //--------------------------------------------------
            Database_Selects.LoadProjectProgressDonut(pieChart1, 1);
            //-----------------------------------------------


            // TODO: This line of code loads data into the 'mangDataSet.members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.mangDataSet.members);


            //-----------------------------------------------------------



            Database_Selects.RefreshDashboardStats(1, lblTotalTasks, lblMembers, lblCompleted, lblRemaining);


            //------------------------------------
            string connString = @"Data Source=DESKTOP-GHA82A2\HUSINSERVER;Initial Catalog=mang;Integrated Security=True;";

           
            

            // 2. إنشاء كائن الاتصال
            using (SqlConnection connection = new SqlConnection(connString))
            {
                // 3. تمرير الاتصال للـ Adapter
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT \r\n    m.m_name ,\r\n    t.tk_name AS [اسم المهمة],\r\n    t.status AS [حالة المهمة],\r\n    CASE \r\n        WHEN t.status = 'Completed' THEN 'مكتملة'\r\n        ELSE 'غير مكتملة'\r\n    END AS [الوضعية]\r\nFROM members m\r\nJOIN tasks t ON m.m_id = t.assigned_to\r\nJOIN projects p ON t.project_id = p.project_id\r\nWHERE p.project_id = 1  -- استبدل هذا باسم المشروع المطلوب\r\nORDER BY m.m_name;", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvMembers.DataSource = dt;
            }
            DataGridView_Design.ApplyDarkTheme(dgvMembers);
            // تجعل الأعمدة تتمدد تلقائياً لتناسب حجم أطول جملة في كل عمود
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // إذا كنت تريد للعمود الأخير أن يملأ باقي مساحة الجدول تماماً
         





        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {
            
                // نفترض أن اسم الـ DataGridView هو dataGridView1
                // واسم العمود في قاعدة البيانات هو "MemberName"
                try
                {
                    string filter = string.Format("m_name LIKE '%{0}%'", txtSearchMember.Text);
                    (dgvMembers.DataSource as DataTable).DefaultView.RowFilter = filter;
                }
                catch (Exception ex)
                {
                MessageBox.Show("حدث خطأ: " + ex.Message);
                // التعامل مع الخطأ في حال عدم وجود بيانات
            }
            
        }
    }
}
