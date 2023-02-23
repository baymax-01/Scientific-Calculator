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
    public partial class Form1 : Form
    {
        double a, b, c,d;
        string opt;
        public Form1()
        {
            InitializeComponent();
        }

        private void arithmaticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 373;
            textBox1.Width = 334;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            this.Width = 770;
            textBox1.Width = 334;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox5.Visible = false;
            groupBox2.Location = new Point(374, 79);
            groupBox2.Width = 373;
            groupBox2.Height = 250;
        }
        private void temperatureConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();          
            Form2 ft = new Form2();
            ft.Show();
        }
        

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }
        private void currencyConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }
        private void constantValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 862;
            textBox1.Width = 334;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox5.Visible = true;
            groupBox2.Location = new Point(369, 79);
            groupBox2.Width = 443;
            groupBox2.Height = 249;
        }
        //Arithmatic Part...........
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        { 
            textBox1.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text=="0")
            {
             textBox1.Text = "0";

            }
            else
            {
                textBox1.Text += "0";
            }
        }


        private void button19_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {

            textBox1.Text += ".";
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text)&&textBox1.Text!=".")
            {

            textBox4.Text = textBox1.Text;
            textBox1.Text = "";
            opt = "+";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != ".")
            {

                textBox4.Text = textBox1.Text;
                textBox1.Text = "";
                opt = "-";
            }
        }


        private void button13_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != ".")
            {

                textBox4.Text = textBox1.Text;
                textBox1.Text = "";
                opt = "*";
            }
        }


        private void button17_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != ".")
            {

                textBox4.Text = textBox1.Text;
                textBox1.Text = "";
                opt = "/";
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox4.Text);
                b = double.Parse(textBox1.Text);
                if (opt == "+")
                {
                    c = a + b;
                    textBox1.Text = Convert.ToString(c);
                }
                else if (opt == "-")
                {
                    c = a - b;
                    textBox1.Text = Convert.ToString(c);
                }
                else if (opt == "*")
                {
                    c = a * b;
                    textBox1.Text = Convert.ToString(c);
                }
                else if (opt == "/")
                {
                    c = a / b;
                    textBox1.Text = Convert.ToString(c);
                }
                else if (opt == "%")
                {
                    c = a % b;
                    textBox1.Text = Convert.ToString(c);
                }
                else if (opt == "pow")
                {
                    c = Math.Pow(a, b);
                    textBox1.Text = c.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter numbers.....");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
             textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);            
            }
        }

        
        
        //Scientific Part..........


        private void button26_Click(object sender, EventArgs e)
        {
            d = double.Parse(textBox1.Text);
            c = Math.Sin(d);
            textBox1.Text = Convert.ToString(c);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            d = double.Parse(textBox1.Text);
            c = Math.Asin(d);
            textBox1.Text = Convert.ToString(c);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            d = double.Parse(textBox1.Text);
            c = Math.Cos(d);
            textBox1.Text = Convert.ToString(c);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            d = double.Parse(textBox1.Text);
            c = Math.Acos(d);
            textBox1.Text = Convert.ToString(c);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            d = double.Parse(textBox1.Text);
            c = Math.Tan(d);
            textBox1.Text = Convert.ToString(c);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            d = double.Parse(textBox1.Text);
            c = Math.Atan(d);
            textBox1.Text = Convert.ToString(c);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            d = double.Parse(textBox1.Text);
            c = Math.Log(d);
            textBox1.Text = Convert.ToString(c);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            d = double.Parse(textBox1.Text);
            c = Math.Log10(d);
            textBox1.Text = Convert.ToString(c);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            d = double.Parse(textBox1.Text);
            c = Math.Sqrt(d);
            textBox1.Text = Convert.ToString(c);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            d = double.Parse(textBox1.Text);
            c = d / 100;
            textBox1.Text = Convert.ToString(c);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != ".")
            {
                textBox4.Text = textBox1.Text;
                textBox1.Text = "";
                opt = "%";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {

                double f = 2.7182818284590;
            d = double.Parse(textBox1.Text);
            c = d*f;
            textBox1.Text = Convert.ToString(c);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox1.Text;
            textBox1.Text = "";
            opt = "pow";
        }


        private void button22_Click(object sender, EventArgs e)
        {
            d = double.Parse(textBox1.Text);
            c =Math.Pow(d,1.0 / 3.0);          
            textBox1.Text = c.ToString();
        }


        private void button25_Click(object sender, EventArgs e)
        {
            d = double.Parse(textBox1.Text);
            c = Math.Pow(d,2);
            textBox1.Text = Convert.ToString(c);
        }


        private void button29_Click(object sender, EventArgs e)
        {
            d = double.Parse(textBox1.Text);
            c = Math.Pow(d, 3);
            textBox1.Text = Convert.ToString(c);
        }


        private void button39_Click(object sender, EventArgs e)
        {
            try
            {

            int g;
            g = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(g,2);
            }
            catch (Exception)
            {

                MessageBox.Show("Too Big number......");
            }
        }
        private void button40_Click(object sender, EventArgs e)
        {
            try
            {
                int g;
                g = int.Parse(textBox1.Text);
                textBox1.Text = System.Convert.ToString(g, 8);
            }
            catch (Exception)
            {

                MessageBox.Show("Too Big number......");
            }
           
        }

        private void button41_Click(object sender, EventArgs e)
        {
            try
            {
                int g;
                g = int.Parse(textBox1.Text);
                textBox1.Text = System.Convert.ToString(g, 16);
            }
            catch (Exception)
            {

                MessageBox.Show("Too Big number......");
            }
            
        }

        private void button52_Click(object sender, EventArgs e)
        {
            int g;
            g = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(g, 10);
        }

        //Constant Value
        private void button38_Click(object sender, EventArgs e)
        {
            double pi;
            pi = 3.141592653589;
            textBox1.Text = Convert.ToString(pi);
        }
        private void button49_Click(object sender, EventArgs e)
        {
            double c;
            c = 3E8;
            textBox1.Text = c.ToString();
        }
        private void button48_Click(object sender, EventArgs e)
        {
            double h;
            h = 6.62607004E-34;
            textBox1.Text = Convert.ToString(h);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            double k;
            k = 9E9;
            textBox1.Text = Convert.ToString(k);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            double me;
          
            me = 9.10938356E-31;
            textBox1.Text = Convert.ToString(me);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            double Na;
            Na = 6.0221409E23;
            textBox1.Text = Convert.ToString(Na);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double q;
            q = 1.60217662E-19;
            textBox1.Text = Convert.ToString(q);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            double G;
            G = 6.67E-11;
            textBox1.Text = Convert.ToString(G);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            double uo;
            uo = 1.256637061E-6;
            textBox1.Text = Convert.ToString(uo);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double hc;
            hc = 1.054571628E-34;
            textBox1.Text = Convert.ToString(hc);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            double Me;
            Me = 5.97219E24;
            textBox1.Text = Convert.ToString(Me);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            double mp;
            mp = 1.6726219E-27;
            textBox1.Text = Convert.ToString(mp);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            double ev;
            ev = 1.60218E-19;
            textBox1.Text = Convert.ToString(ev);
        }
        private void button42_Click(object sender, EventArgs e)
        {
            double eo;
            eo = 8.854187817E-12;
            textBox1.Text = Convert.ToString(eo);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            double Re;
            Re = 6378.1E3;
            textBox1.Text = Convert.ToString(Re);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            double g;
            g = 9.8;
            textBox1.Text = Convert.ToString(g);
        }


    }
}
