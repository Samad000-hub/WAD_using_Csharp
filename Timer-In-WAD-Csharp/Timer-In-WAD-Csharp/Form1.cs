using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_In_WAD_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(label1.Text);
            val = val + 1;
            label1.Text = Convert.ToString(val);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled==true)
            {
                timer1.Enabled = false;
                button1.Text = "Start";
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Stop";
            }
        }
    }
}
