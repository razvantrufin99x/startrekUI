using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace startrekUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            pictureBox1.Image = pictureBox2.Image;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox3.Image;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = pictureBox4.Image;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = pictureBox6.Image;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = pictureBox9.Image;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.Image = pictureBox8.Image;
        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox10.Image = pictureBox11.Image;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = pictureBox12.Image;
        }

        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox13.Image = pictureBox14.Image;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Image = pictureBox15.Image;
        }

       

        

       
    }
}
