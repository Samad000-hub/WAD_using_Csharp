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

namespace Controls_Basics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortTimeString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("--Select--");
            comboBox2.Items.Add("--Samad--");
            comboBox2.Items.Add("--Not Samad--");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text.Trim();
            if (s != "")
            {
                comboBox3.Items.Add(s);
                MessageBox.Show("Total items are" + comboBox3.Items.Count);
            }
            else
            {
                MessageBox.Show("Text is empty");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result==System.Windows.Forms.DialogResult.OK)
            {
                String name = openFileDialog1.FileName;
                pictureBox1.Load(name);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                String name = openFileDialog1.FileName;
                StreamReader reader = new StreamReader(name);
                string text = reader.ReadToEnd();
                textBox2.Text = text;
                reader.Close();
            }
        }
    }
}
