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

        private void button1_Click(object sender, EventArgs e)
        {

            Classpanelcont.OpenChildForm(panelcont, new Form2());
           label1.Text=button1.Text;
          
          

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
            Classpanelcont.OpenChildForm(panelcont, new FormProject());



            label1.Text = buttonproj.Text;

        }


       //-----------------------------------------------------------




        



        

        
    }
}
