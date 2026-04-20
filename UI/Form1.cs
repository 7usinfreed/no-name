using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // 1. إنشاء نسخة من النموذج المراد فتحه
            Form2 childForm = new Form2();

            // 2. ضبط خصائص النموذج ليتمكن من الدخول داخل حاوية
            childForm.TopLevel = false; // مهم جداً: لكي لا يتعامل معه الويندوز كنافذة مستقلة
            childForm.FormBorderStyle = FormBorderStyle.None; // لإزالة الحواف وشريط العنوان
            childForm.Dock = DockStyle.Fill; // لملء المساحة بالكامل داخل الـ Panel

            // 3. إضافة النموذج إلى الـ Panel وإظهاره
            panelcont.Controls.Clear(); // مسح أي محتوى سابق داخل الـ Panel
            panelcont.Controls.Add(childForm); // إضافة النموذج للوحة
            childForm.Show(); // إظهار النموذج


            panelhome.BackColor = Color.WhiteSmoke;
            panel1.BackColor = Color.Gray;
            button2.BackColor = Color.Teal;
            button1.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.Teal;
            button5.BackColor = Color.Teal;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // 1. إنشاء نسخة من النموذج المراد فتحه
            Form3 childForm = new Form3();

            // 2. ضبط خصائص النموذج ليتمكن من الدخول داخل حاوية
            childForm.TopLevel = false; // مهم جداً: لكي لا يتعامل معه الويندوز كنافذة مستقلة
            childForm.FormBorderStyle = FormBorderStyle.None; // لإزالة الحواف وشريط العنوان
            childForm.Dock = DockStyle.Fill; // لملء المساحة بالكامل داخل الـ Panel

            // 3. إضافة النموذج إلى الـ Panel وإظهاره
            panelcont.Controls.Clear(); // مسح أي محتوى سابق داخل الـ Panel
            panelcont.Controls.Add(childForm); // إضافة النموذج للوحة
            childForm.Show(); // إظهار النموذج

            panelhome.BackColor = Color.Red;
            panel1.BackColor = Color.DarkRed;
            button1.BackColor = Color.Teal;
            button2.BackColor = Color.Red;
            button4.BackColor = Color.Teal;
            button5.BackColor = Color.Teal;




        }

        private void button4_Click(object sender, EventArgs e)
        {

            // 1. إنشاء نسخة من النموذج المراد فتحه
            Form4 childForm = new Form4();

            // 2. ضبط خصائص النموذج ليتمكن من الدخول داخل حاوية
            childForm.TopLevel = false; // مهم جداً: لكي لا يتعامل معه الويندوز كنافذة مستقلة
            childForm.FormBorderStyle = FormBorderStyle.None; // لإزالة الحواف وشريط العنوان
            childForm.Dock = DockStyle.Fill; // لملء المساحة بالكامل داخل الـ Panel

            // 3. إضافة النموذج إلى الـ Panel وإظهاره
            panelcont.Controls.Clear(); // مسح أي محتوى سابق داخل الـ Panel
            panelcont.Controls.Add(childForm); // إضافة النموذج للوحة
            childForm.Show(); // إظهار النموذج


            panelhome.BackColor = Color.Blue;
            panel1.BackColor = Color.DarkBlue;
            button1.BackColor = Color.Teal;
            button4.BackColor = Color.Blue;
            button2.BackColor = Color.Teal;
            button5.BackColor = Color.Teal;




        }

        private void button5_Click(object sender, EventArgs e)
        {

            // 1. إنشاء نسخة من النموذج المراد فتحه
            Form5 childForm = new Form5();

            // 2. ضبط خصائص النموذج ليتمكن من الدخول داخل حاوية
            childForm.TopLevel = false; // مهم جداً: لكي لا يتعامل معه الويندوز كنافذة مستقلة
            childForm.FormBorderStyle = FormBorderStyle.None; // لإزالة الحواف وشريط العنوان
            childForm.Dock = DockStyle.Fill; // لملء المساحة بالكامل داخل الـ Panel

            // 3. إضافة النموذج إلى الـ Panel وإظهاره
            panelcont.Controls.Clear(); // مسح أي محتوى سابق داخل الـ Panel
            panelcont.Controls.Add(childForm); // إضافة النموذج للوحة
            childForm.Show(); // إظهار النموذج




            panelhome.BackColor = Color.Green;
            button1.BackColor = Color.Teal;
            panel1.BackColor = Color.DarkGreen;
            button4.BackColor = Color.Teal;
            button2.BackColor = Color.Teal;
            button5.BackColor = Color.Green;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.WhiteSmoke;


        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Teal;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor= Color.Red;
            

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Teal;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Blue;


        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Teal;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Green;


        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Teal;
        }
    }
}
