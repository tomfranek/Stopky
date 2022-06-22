using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopky
{
    public partial class Form1 : Form
    {

        int cas;
        public Form1()
        {
            InitializeComponent();
            cas = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Start";


            }
            else
            {
                cas = 0;
                timer1.Enabled = true;
                button1.Text = "Stop";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cas++;
            float c = (float)cas / 10;
            label1.Text = c.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0,0";
        }
    }
}
