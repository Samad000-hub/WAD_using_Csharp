using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAD_Practice_1
{
    //Multiple classes can create with same name but use 'partial'keyword.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(txtFirst.Text);
            int second = Convert.ToInt32(txtSecond.Text);

            txtResult.Text = (first + second).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(txtFirst.Text);
            int second = Convert.ToInt32(txtSecond.Text);

            txtResult.Text = (first - second).ToString();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(txtFirst.Text);
            int second = Convert.ToInt32(txtSecond.Text);

            txtResult.Text = (first * second).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(txtFirst.Text);
            int second = Convert.ToInt32(txtSecond.Text);
            float res = ((float)first / second);
            txtResult.Text = res.ToString();
        }
    }
}
