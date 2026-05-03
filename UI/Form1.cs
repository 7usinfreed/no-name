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

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Classpanelcont.OpenChildForm(panelcont, new Form2());

          
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classpanelcont.OpenChildForm(panelcont, new Form3());





        }

        private void button4_Click(object sender, EventArgs e)
        {
            Classpanelcont.OpenChildForm(panelcont, new Form4());

          
         




        }

        private void button5_Click(object sender, EventArgs e)
        {

            Classpanelcont.OpenChildForm(panelcont, new Form5());




          
           
        }

        private void buttonproj_Click(object sender, EventArgs e)
        {
            Classpanelcont.OpenChildForm(panelcont, new FormProject());



        }


       //-----------------------------------------------------------




        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(44, 62, 80);


        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Teal;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor= Color.FromArgb(44, 62, 80);
            

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Teal;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(44, 62, 80);


        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Teal;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(44, 62, 80);


        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Teal;
        }

        private void buttonprol_MouseEnter(object sender, EventArgs e)
        {
            buttonproj.BackColor = Color.FromArgb(44, 62, 80);


        }

        private void buttonproj_MouseLeave(object sender, EventArgs e)
        {
            buttonproj.BackColor = Color.Teal;
        }



        

        
    }
}
