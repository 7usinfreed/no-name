using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts; // لا تنسَ إضافة هذا السطر في الأعلى
using LiveCharts.Wpf;
using static UI.Classpanelcont;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sidepanel.SetupSideMenu(this.panelbtn);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            Classpanelcont.OpenChildForm(panelcont, new FormProject());
            label1.Text = btnHome.Text;
          
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            Classpanelcont.OpenChildForm(panelcont, new Form4());


            label1.Text = button4.Text;




        }

        private void button5_Click(object sender, EventArgs e)
        {

            Classpanelcont.OpenChildForm(panelcont, new Form5());


            label1.Text = button5.Text;



        }

        private void buttonproj_Click(object sender, EventArgs e)
        {
            Classpanelcont.OpenChildForm(panelcont, new Form2());



            label1.Text = buttonproj.Text;

        }

        private void btnWelcomeNew_Click(object sender, EventArgs e)
        {
            panelbtn.Visible = true;
            panel3.Visible = false;
            panel3.Enabled = false;

            btnHome_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelbtn.Visible = true;

            btnHome_Click(sender, e);
        }

        private void panelcont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        //-----------------------------------------------------------











    }
}
