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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void arithmaticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            pictureBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double CC, amount;
                amount = double.Parse(textBox1.Text);
                if (comboBox1.Text == "US Dollar DD-PKR")
                {
                    CC = amount * 177.2;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Australian Dollar-PKR")
                {
                    CC = amount * 122.65;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Bahrain Dinar-PKR")
                {
                    CC = amount * 386.95;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Canadian Dollar-PKR")
                {
                    CC = amount * 138.15;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "China Yuan-PKR")
                {
                    CC = amount * 23.5;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Danish Krone-PKR")
                {
                    CC = amount * 23.6;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Euro-PKR")
                {
                    CC = amount * 197.15;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Hong Kong Dollar-PKR")
                {
                    CC = amount * 16.95;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Indian Rupee-PKR")
                {
                    CC = amount * 2.03;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Japanese Yen-PKR")
                {
                    CC = amount * 1.41;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Kuwaiti Dinar-PKR")
                {
                    CC = amount * 481.85;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Malaysian Ringgit-PKR")
                {
                    CC = amount * 36.65;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "NewZealand $-PKR")
                {
                    CC = amount * 96.65;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Norwegians Krone-PKR")
                {
                    CC = amount * 17.5;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Omani Riyal-PKR")
                {
                    CC = amount * 392.85;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Qatari Riyal-PKR")
                {
                    CC = amount * 39.95;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Saudi Riyal-PKR")
                {
                    CC = amount * 46.85;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Singapore Dollar-PKR")
                {
                    CC = amount * 128.85;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Swedish Korona-PKR")
                {
                    CC = amount * 18.7;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Swiss Franc-PKR")
                {
                    CC = amount * 160.25;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "Thai Bhat-PKR")
                {
                    CC = amount * 4.8;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "U.A.E Dirham-PKR")
                {
                    CC = amount * 49.1;
                    textBox2.Text = CC.ToString();
                }
                else if (comboBox1.Text == "UK Pound Sterling-PKR")
                {
                    CC = amount * 237.1;
                    textBox2.Text = CC.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter amount....");
            }
            
            
        }
        public void c()
        {
            try
            {
                double CC, amount;
                amount = double.Parse(textBox3.Text);
                if (comboBox2.Text == "PKR-US Dollar DD")
                {
                    CC = amount / 177.2;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Australian Dollar")
                {
                    CC = amount / 122.65;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Bahrain Dinar")
                {
                    CC = amount / 386.95;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Canadian Dollar")
                {
                    CC = amount / 138.15;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-China Yuan")
                {
                    CC = amount / 23.5;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Danish Krone")
                {
                    CC = amount / 23.6;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Euro")
                {
                    CC = amount / 197.15;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Hong Kong Dollar")
                {
                    CC = amount / 16.95;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Indian Rupee")
                {
                    CC = amount / 2.03;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Japanese Yen")
                {
                    CC = amount / 1.41;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Kuwaiti Dinar")
                {
                    CC = amount / 481.85;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Malaysian Ringgit")
                {
                    CC = amount / 36.65;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-NewZealand $")
                {
                    CC = amount / 96.65;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Norwegians Krone")
                {
                    CC = amount / 17.5;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Omani Riyal")
                {
                    CC = amount / 392.85;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Qatari Riyal")
                {
                    CC = amount / 39.95;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Saudi Riyal")
                {
                    CC = amount / 46.85;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Singapore Dollar")
                {
                    CC = amount / 128.85;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Swedish Korona")
                {
                    CC = amount / 18.7;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Swiss Franc")
                {
                    CC = amount / 160.25;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-Thai Bhat")
                {
                    CC = amount / 4.8;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-U.A.E Dirham")
                {
                    CC = amount / 49.1;
                    textBox4.Text = CC.ToString();
                }
                else if (comboBox2.Text == "PKR-UK Pound Sterling")
                {
                    CC = amount / 237.1;
                    textBox4.Text = CC.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter amount....");
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Choose one....";
            comboBox2.Text = "Choose one....";
        }
    }
}
