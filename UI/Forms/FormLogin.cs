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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textboxuser.Text == "ahmed" && textboxpass.Text == "123")
            {
                Form1 Form1 = new Form1();
                Form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is uncorrect !");
            }
        }
    }
}
