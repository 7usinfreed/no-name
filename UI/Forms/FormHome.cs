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

            Database_Selects.DisplayMembers(dgvMembers, 1);
            DataGridView_Design.ApplyDarkTheme(dgvMembers);
            // تجعل الأعمدة تتمدد تلقائياً لتناسب حجم أطول جملة في كل عمود
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // إذا كنت تريد للعمود الأخير أن يملأ باقي مساحة الجدول تماماً
            dgvMembers.Columns[dgvstatus.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;





        }

        
    }
}
