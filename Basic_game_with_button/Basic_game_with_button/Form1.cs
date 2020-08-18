using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_game_with_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnMove.Left = btnMove.Left + 10;
            if (btnMove.Right >= this.Width)
            {
                btnMove.Left = this.Width - btnMove.Width;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            btnMove.Top = btnMove.Top - 10;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            btnMove.Top = btnMove.Top + 10;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            btnMove.Left = btnMove.Left - 10;
            if (btnMove.Left < 0)
            {
                btnMove.Left = 0;
            }
        }

        private void objLeft_Click(object sender, EventArgs e)
        {
            MessageBox.Show(btnMove.Left.ToString());
        }

        private void objWidth_Click(object sender, EventArgs e)
        {
            MessageBox.Show(btnMove.Width.ToString());
        }

        private void objTop_Click(object sender, EventArgs e)
        {
            MessageBox.Show(btnMove.Top.ToString());
        }

        private void objHeight_Click(object sender, EventArgs e)
        {
            MessageBox.Show(btnMove.Height.ToString());
        }

        private void frmwidth_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Width.ToString());
        }

        private void frmheight_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Height.ToString());
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
