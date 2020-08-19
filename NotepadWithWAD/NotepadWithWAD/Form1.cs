using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControls
{
    public partial class Form1 : Form
    {
        string fileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            fileName = "";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var result = openFileDialog2.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                fileName = openFileDialog2.FileName;
                StreamReader reader = new StreamReader(fileName);
                String text = reader.ReadToEnd();
                textBox2.Text = text;
                reader.Close();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                var result = saveFileDialog1.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    fileName = saveFileDialog1.FileName;
                }
            }
            if(fileName != "")
            {
                StreamWriter writer = new StreamWriter(fileName);
                writer.Write(textBox2.Text);
                writer.Flush();
                writer.Close();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                if (fileName != "")
                {
                    StreamWriter writer = new StreamWriter(fileName);
                    writer.Write(textBox2.Text);
                    writer.Flush();
                    writer.Close();
                }
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
