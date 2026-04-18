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


            panelhome.BackColor = Color.Teal;
            panel1.BackColor = Color.DarkSlateGray;
            button2.BackColor = Color.Teal;
           
            button4.BackColor = Color.Teal;
            button5.BackColor = Color.Teal;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelhome.BackColor = Color.Red;
            panel1.BackColor = Color.DarkRed;
            button2.BackColor = Color.Red;
            button4.BackColor = Color.Teal;
            button5.BackColor = Color.Teal;




        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelhome.BackColor = Color.Blue;
            panel1.BackColor = Color.DarkBlue;
            button4.BackColor = Color.Blue;
            button2.BackColor = Color.Teal;
            button5.BackColor = Color.Teal;



        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelhome.BackColor = Color.Green;
            panel1.BackColor = Color.DarkGreen;
            button4.BackColor = Color.Teal;
            button2.BackColor = Color.Teal;
            button5.BackColor = Color.Green;
        }
    }
}
