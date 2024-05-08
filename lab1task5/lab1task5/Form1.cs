using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_SuperBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі мене цього не позбавиш!");
        }

        private void button1_Opacity_Click(object sender, EventArgs e)
        {
            Opacity = 1.5 - Opacity;
        }

        private void button2_Color_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.LightGray)
            {
                BackColor = Color.Yellow;
                return;
            }
            BackColor = Color.LightGray;
        }

        private void button3_HelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");
        }
        private void checkBox1_Opacity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_Opacity.Checked)
            {
                button4_SuperBtn.Click += new EventHandler(button1_Opacity_Click);
                return;
            }
            button4_SuperBtn.Click -= new EventHandler(button1_Opacity_Click);
        }
        private void checkBox2_Color_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_Color.Checked)
            {
                button4_SuperBtn.Click += new EventHandler(button2_Color_Click);
                return;
            }
            button4_SuperBtn.Click -= new EventHandler(button2_Color_Click);
        }

        private void checkBox3_HelloWorld_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3_HelloWorld.Checked)
            {
                button4_SuperBtn.Click += new EventHandler(button3_HelloWorld_Click);
                return;
            }
            button4_SuperBtn.Click -= new EventHandler(button3_HelloWorld_Click);
        }
    }
}
