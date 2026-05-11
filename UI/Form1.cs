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
using System.Runtime.InteropServices;
using static UI.Classpanelcont;

namespace UI
{
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color_btn_panel.SetupSideMenu(this.panelbtn);
            


        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Classpanelcont.OpenChildForm(panelcont, new FormMainpage());



            label1.Text = btnHome.Text;
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            Classpanelcont.OpenChildForm(panelcont, new FormHome());
            label1.Text = btnProject.Text;
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            Classpanelcont.OpenChildForm(panelcont, new Form4());


            label1.Text = btnEdit.Text;
        }

        private void btnSitting_Click(object sender, EventArgs e)
        {
            Classpanelcont.OpenChildForm(panelcont, new Form5());


            label1.Text = btnSitting.Text;

        }


        //------------------------زر الاغلاق

        private void Closebox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void Closebox_MouseEnter(object sender, EventArgs e)
        {
            Closebox.BackColor = Color.Red;
        }
        private void Closebox_MouseLeave(object sender, EventArgs e)
        {
            Closebox.BackColor = Color.FromArgb(230, 126, 34);
        }


        //----------------------------زر التصغير
        private void minimizedbox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizedbox_MouseEnter(object sender, EventArgs e)
        {
            minimizedbox.BackColor = Color.LightGray;
        }
        private void minimizedbox_MouseLeave(object sender, EventArgs e)
        {
            minimizedbox.BackColor = Color.FromArgb(230, 126, 34);
        }

        private void panelhome_MouseDown(object sender, MouseEventArgs e)
        {
            // التأكد من أن الضغط تم بالزر الأيسر للماوس
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

       


















        //-----------------------------------------------------------











    }
}
