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
        bool isDragging = false;
        Point lastCursorPosition;
        public Form1()
        {
            InitializeComponent();
        }
        private void panelhome_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursorPosition = e.Location; // تخزين موقع الماوس عند بدء الضغط
        }

        private void panelhome_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // حساب الفرق بين الموقع الحالي والموقع السابق وتحريك الفورم
                this.Location = new Point(
                    (this.Location.X - lastCursorPosition.X) + e.X,
                    (this.Location.Y - lastCursorPosition.Y) + e.Y);

                this.Update(); // تحديث واجهة الفورم أثناء الحركة لمنع التقطيع
            }
        }

        private void panelhome_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false; // التوقف عن التحريك عند رفع الإصبع عن الماوس
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
            Classpanelcont.OpenChildForm(panelcont, new FormHome());



            label1.Text = buttonproj.Text;

        }

        private void btnWelcomeNew_Click(object sender, EventArgs e)
        {
            panelbtn.Visible = true;
            panelWelcome.Visible = false;
            panelWelcome.Enabled = false;

            btnHome_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelbtn.Visible = true;

            btnHome_Click(sender, e);
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void pboxMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pboxClose_MouseEnter(object sender, EventArgs e)
        {
            pboxClose.BackColor = Color.Red;
        }

        private void pboxClose_MouseLeave(object sender, EventArgs e)
        {
            pboxClose.BackColor = Color.FromArgb(230, 126, 34);
        }

        private void pboxMinimized_MouseEnter(object sender, EventArgs e)
        {
            pboxMinimized.BackColor = Color.LightGray;
        }

        private void pboxMinimized_MouseLeave(object sender, EventArgs e)
        {
            pboxMinimized.BackColor = Color.FromArgb(230, 126, 34);
        }








        //-----------------------------------------------------------











    }
}
