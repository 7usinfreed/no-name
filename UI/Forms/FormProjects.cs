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
    public partial class FormProjects : Form
    {
        public FormProjects()
        {
            InitializeComponent();
        }

        private void FormProjects_Load(object sender, EventArgs e)
        {

            DataGridView_Design.ApplyDarkTheme(dataGridView1);

            //--------------------------------------------------

            
            Database_Selects.DisplayStatusSummary(dataGridView1, 2);
            // تجعل الأعمدة تتمدد تلقائياً لتناسب حجم أطول جملة في كل عمود
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // إذا كنت تريد للعمود الأخير أن يملأ باقي مساحة الجدول تماماً
            dataGridView1.Columns[dataGridView1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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









        }

       
    }
}
