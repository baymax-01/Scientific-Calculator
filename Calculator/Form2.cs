using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void arithmaticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ft = new Form1();
            ft.Show();           
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f2 = new Form4();
            f2.Show();
        }

        private void pKRCurrencyConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f2 = new Form5();
            f2.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double temp,tb2;
            tb2 = double.Parse(textBox2.Text);

            if (radioButton1.Checked)
            {
                temp = ((tb2 * 9) / 5) + 32;
                textBox3.Text = temp.ToString();
            }
            else if (radioButton2.Checked)
            {
                temp = ((tb2 - 32) * 5) / 9;
                textBox3.Text = temp.ToString();

            }
            else if (radioButton4.Checked)
            {
                temp = tb2 + 273;
                textBox3.Text = temp.ToString();
            }
            else if (radioButton5.Checked)
            {

                temp = (((tb2 - 273) * 9) / 5) + 32;
                textBox3.Text = temp.ToString();

            }
            else if (radioButton6.Checked)
            {
                temp = tb2 - 273;
                textBox3.Text = temp.ToString();
            }
            else if (radioButton3.Checked)
            {
                temp = (((tb2 - 32) * 5) / 9) + 273;
                textBox3.Text = temp.ToString();

            }
        }
          
        

        private void button37_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

    }
}
