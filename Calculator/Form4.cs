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
    public partial class Form4 : Form
    {
        double tb1, converter;
        public Form4()
        {
            InitializeComponent();
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void arithmaticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void temperatureConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
           //FOR VOLUME        
            comboBox1.Text = "Choose any one......";
            comboBox1.Items.Add("Choose any one.....");
            comboBox1.Items.Add("Milliliter-Liter");
            comboBox1.Items.Add("Centiliter-Liter");
            comboBox1.Items.Add("Deciliter-Liter");
            comboBox1.Items.Add("Decaliter-Liter");
            comboBox1.Items.Add("Hectoliter-Liter");
            comboBox1.Items.Add("Kiloliter-Liter");
            comboBox1.Items.Add("Cubic inch-Liter");
            comboBox1.Items.Add("Gallon-Liter");
            comboBox1.Items.Add("Cubic foot-Liter");

            //FOR LENGTH
            comboBox2.Text = "Choose any one.....";
            comboBox2.Items.Add("Choose any one.....");
            comboBox2.Items.Add("Millimeter-meter");
            comboBox2.Items.Add("Centimeter-meter");
            comboBox2.Items.Add("Decimetermeter-meter");
            comboBox2.Items.Add("Hectometer-meter");
            comboBox2.Items.Add("Decameter-meter");
            comboBox2.Items.Add("Kilometer-meter");
            comboBox2.Items.Add("Inch-meter");
            comboBox2.Items.Add("Foot-meter");         
            comboBox2.Items.Add("light year-meter");
            comboBox2.Items.Add("mile-meter");

            //For MASS
            comboBox3.Text = "Choose any one.....";
            comboBox3.Items.Add("Choose any one.....");
            comboBox3.Items.Add("Milligram-gram");
            comboBox3.Items.Add("Centigram-gram");
            comboBox3.Items.Add("Decigram-gram");
            comboBox3.Items.Add("Hectagram-gram");
            comboBox3.Items.Add("Decagram-gram");
            comboBox3.Items.Add("Kilogram-gram");
            comboBox3.Items.Add("gram-Kilogram");

            //ENERGY
            comboBox4.Text = "Choose any one.....";
            comboBox4.Items.Add("Choose any one.....");
            comboBox4.Items.Add("BTU-Joule");
            comboBox4.Items.Add("erg-Joule");
            comboBox4.Items.Add("foot pound-joule");
            comboBox4.Items.Add("calorie-Joule");
            comboBox4.Items.Add("Kilowatthour-Joule");
            comboBox4.Items.Add("ev-Joule");
            comboBox4.Items.Add("Litre atmosphere-Joule");

            //for TIME
            comboBox5.Text = "Choose any one.....";
            comboBox5.Items.Add("Choose any one.....");
            comboBox5.Items.Add("Min-Sec");
            comboBox5.Items.Add("Hour-Sec");
            comboBox5.Items.Add("Day-Hours");
            comboBox5.Items.Add("Week-Days");
            comboBox5.Items.Add("Year-Days");

            //FOR AREA
            comboBox6.Text = "Choose any one.....";
            comboBox6.Items.Add("Choose any one.....");
            comboBox6.Items.Add("Sq.inch-Sq.meter");
            comboBox6.Items.Add("Sq.foot-Sq.meter");
            comboBox6.Items.Add("acre-Sq.meter");
            comboBox6.Items.Add("hecta.acre-Sq.meter");
            comboBox6.Items.Add("sq.mile-Sq.meter");
            comboBox6.Items.Add("Barn-Sq.meter");

            //FOR POWER
            comboBox7.Text = "Choose any one.....";
            comboBox7.Items.Add("Choose any one.....");
            comboBox7.Items.Add("erg/sec-watt");
            comboBox7.Items.Add("BTU/hr-watt");
            comboBox7.Items.Add("foot.pound/sec-watt");
            comboBox7.Items.Add("horsepower-watt");
            comboBox7.Items.Add("calorie/sec-watt");

            //FOR VISCOSITY
            comboBox8.Text = "Choose any one.....";
            comboBox8.Items.Add("Choose any one.....");
            comboBox8.Items.Add("poise-kg/m.s");
            comboBox8.Items.Add("slug/ft-kg/m.s");

            //FOR FORCE
            comboBox9.Text = "Choose any one.....";
            comboBox9.Items.Add("Choose any one.....");
            comboBox9.Items.Add("dyne-Newton");
            comboBox9.Items.Add("pound-Newton");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                textBox1.Text = "";
                textBox2.Text = "";
            comboBox1.Text = "Choose any one......";
            comboBox2.Text = "Choose any one......";
            comboBox3.Text = "Choose any one......";
            comboBox4.Text = "Choose any one......";
            comboBox5.Text = "Choose any one......";
            comboBox6.Text = "Choose any one......";
            comboBox7.Text = "Choose any one......";
            comboBox8.Text = "Choose any one......";
            comboBox9.Text = "Choose any one......";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tb1 = double.Parse(textBox1.Text);
                //FOR VOLUME
                if (comboBox1.Text == "Milliliter-Liter")
                {
                    converter = tb1 * 0.001;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox1.Text == "Centiliter-Liter")
                {
                    converter = tb1 * 0.01;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox1.Text == "Deciliter-Liter")
                {
                    converter = tb1 * 0.1;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox1.Text == "Decaliter-Liter")
                {
                    converter = tb1 * 10;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox1.Text == "Hectoliter-Liter")
                {
                    converter = tb1 * 100;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox1.Text == "Kiloliter-Liter")
                {
                    converter = tb1 * 1000;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox1.Text == "Cubic inch-Liter")
                {
                    converter = tb1 * 1.639E-2;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox1.Text == "Gallon-Liter")
                {
                    converter = tb1 * 3.785;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox1.Text == "Cubic foot-Liter")
                {
                    converter = tb1 * 28.316;
                    textBox2.Text = converter.ToString();
                }
                //Length
                else if (comboBox2.Text == "Millimeter-meter")
                {
                    converter = tb1 * 0.001;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox2.Text == "Centimeter-meter")
                {
                    converter = tb1 * 0.01;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox2.Text == "Decimetermeter-meter")
                {
                    converter = tb1 * 0.1;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox2.Text == "Hectometer-meter")
                {
                    converter = tb1 * 10;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox2.Text == "Decameter-meter")
                {
                    converter = tb1 * 100;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox2.Text == "Kilometer-meter")
                {
                    converter = tb1 * 1000;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox2.Text == "Inch-meter")
                {
                    converter = tb1 * 2.54E-2;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox2.Text == "Foot-meter")
                {
                    converter = tb1 * 0.3048;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox2.Text == "light year-meter")
                {
                    converter = tb1 * 0.946E16;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox2.Text == "mile-meter")
                {
                    converter = tb1 * 1.609344;
                    textBox2.Text = converter.ToString();
                }
                //FOR MASS
                else if (comboBox3.Text == "Milligram-gram")
                {
                    converter = tb1 * 0.001;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox3.Text == "Centigram-gram")
                {
                    converter = tb1 * 0.01;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox3.Text == "Decigram-gram")
                {
                    converter = tb1 * 0.1;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox3.Text == "Hectagram-gram")
                {
                    converter = tb1 * 100;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox3.Text == "Decagram - gram")
                {
                    converter = tb1 * 10;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox3.Text == "Kilogram-gram")
                {
                    converter = tb1 * 1000;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox3.Text == "gram-Kilogram")
                {
                    converter = tb1 / 1000;
                    textBox2.Text = converter.ToString();
                }
                //FOR ENERGY
                else if (comboBox4.Text == "BTU-Joule")
                {
                    converter = tb1 * 1055;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox4.Text == "erg-Joule")
                {
                    converter = tb1 * 1E-7;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox4.Text == "foot pound-joule")
                {
                    converter = tb1 * 1.356;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox4.Text == "calorie-Joule")
                {
                    converter = tb1 * 4.186;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox4.Text == "Kilowatthour-Joule")
                {
                    converter = tb1 * 3.6E6;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox4.Text == "ev-Joule")
                {
                    converter = tb1 * 1.602E-19;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox4.Text == "Litre atmosphere-Joule")
                {
                    converter = tb1 * 101.13;
                    textBox2.Text = converter.ToString();
                }
                //FOR TIME
                else if (comboBox5.Text == "Min-Sec")
                {
                    converter = tb1 * 60;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox5.Text == "Hour-Sec")
                {
                    converter = tb1 * 3600;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox5.Text == "Day-Hours")
                {
                    converter = tb1 * 24;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox5.Text == "Week-Days")
                {
                    converter = tb1 * 7;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox5.Text == "Year-Days")
                {
                    converter = tb1 * 365;
                    textBox2.Text = converter.ToString();
                }
                //FOR AREA
                else if (comboBox6.Text == "Sq.inch-Sq.meter")
                {
                    converter = tb1 * 6.4516E-4;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox6.Text == "Sq.foot-Sq.meter")
                {
                    converter = tb1 * 9.2903E-2;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox6.Text == "acre-Sq.meter")
                {
                    converter = tb1 * 4.0468E3;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox6.Text == "hecta.acre-Sq.meter")
                {
                    converter = tb1 * 1E4;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox6.Text == "sq.mile-Sq.meter")
                {
                    converter = tb1 * 2.5888E6;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox6.Text == "Barn-Sq.meter")
                {
                    converter = tb1 * 1E-28;
                    textBox2.Text = converter.ToString();
                }
                //FOR POWER
                else if (comboBox7.Text == "erg/sec-watt")
                {
                    converter = tb1 * 1E-5;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox7.Text == "BTU/hr-watt")
                {
                    converter = tb1 * 0.2930;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox7.Text == "foot.pound/sec-watt")
                {
                    converter = tb1 * 1.356;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox7.Text == "horsepower-watt")
                {
                    converter = tb1 * 746;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox7.Text == "calorie/sec-watt")
                {
                    converter = tb1 * 4.186;
                    textBox2.Text = converter.ToString();
                }
                //FOR VISCOSITY
                else if (comboBox8.Text == "poise-kg/m.s")
                {
                    converter = tb1 * 0.1;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox8.Text == "slug/ft-kg/m.s")
                {
                    converter = tb1 * 4.79E1;
                    textBox2.Text = converter.ToString();
                }
                //FOR FORCE
                else if (comboBox9.Text == "dyne-Newton")
                {
                    converter = tb1 * 1E-5;
                    textBox2.Text = converter.ToString();
                }
                else if (comboBox9.Text == "pound-Newton")
                {
                    converter = tb1 * 4.448;
                    textBox2.Text = converter.ToString();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Please Enter value.......");
            }
        }      
    }
}
