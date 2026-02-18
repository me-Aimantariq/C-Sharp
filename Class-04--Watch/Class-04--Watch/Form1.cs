using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_04__Watch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblmsec_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblMinSec.Text = "00";
            lblSec.Text = "00";
            lblMin.Text = "00";
            lblHr.Text = "00";
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int msec = Convert.ToInt32(lblMinSec.Text);
            int sec = Convert.ToInt32(lblSec.Text);
            int mins = Convert.ToInt32(lblMin.Text);
            int hrs = Convert.ToInt32(lblHr.Text);
            msec = msec + 1;
            lblMinSec.Text = msec.ToString();

            if (msec >= 60)
            {
                lblMinSec.Text = "00";
                sec = sec + 1;
                lblSec.Text = sec.ToString();
            }
            else if(sec >= 60)
            {
                lblSec.Text = "00";
                mins = mins + 1;
                lblMin.Text = lblMin.ToString();
            }
            else if (mins >= 60)
            {
                lblMin.Text = "00";
                hrs = hrs + 1;
                lblHr.Text = lblHr.ToString();
            }
        }
    }
}
