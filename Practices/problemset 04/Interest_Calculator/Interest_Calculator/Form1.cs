using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interest_Calculator
{
    public partial class Interest_Calculator : Form
    {
        public Interest_Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rulesCombo = rulesComboBox.Text;
            if(rulesCombo == "Total P+I (A)")
            {
                timeComboBox.Visible = true;
                rulesLabel.Text = "Where: A = P(1 + rt)";
                firstInputLabel.Text = "Principal (P): $";
                secondInputLabel.Text = "Rate ( R ): %";
                yearLabel.Text = "per year";
                thirdInputLabel.Text = "Time ( t ):";
                thirdTextBoxLabel.Text = "";
                //textBox1.Name = "P";
                // calculateA();


            }
            else if (rulesCombo == "Principal (P)")
            {
                timeComboBox.Visible = true;
                rulesLabel.Text = "Where: P = A / (1 + rt) ";
                firstInputLabel.Text = "Total P+I (A): $";
                secondInputLabel.Text = "Rate (R): %";
                yearLabel.Text = "per year";
                thirdInputLabel.Text = "Time (t):";
            }
            else if (rulesCombo == "Rate (R)")
            {
                timeComboBox.Visible = true;
                rulesLabel.Text = "Where: r = (1/t)(A/P - 1) ";
                firstInputLabel.Text = "Total P+I (A): $";
                secondInputLabel.Text = "Principal (P): $";
                yearLabel.Text = "";
                thirdInputLabel.Text = "Time (t):";
            }
            else if (rulesCombo == "Time Period (t)")
            {
                rulesLabel.Text = "Where: t = (1/r)(A/P - 1) ";
                firstInputLabel.Text = "Total P+I (A): $";
                secondInputLabel.Text = "Principal (P): $";
                yearLabel.Text = String.Empty;
                thirdInputLabel.Text = "Rate (R): %";
                timeComboBox.Visible = false;
                thirdTextBoxLabel.Text = "per year";
            }

        }
        Double timeMeasure()
        {
            double dividorTime = 1;
            if(timeComboBox.Text == "days ( 365/Yr )")
            {
                dividorTime = 365;
            }
            else if(timeComboBox.Text == "days ( 360/Yr )")
            {
                dividorTime = 360;
            }
            else if (timeComboBox.Text == "weeks")
            {
                dividorTime = 52;
            }
            else if (timeComboBox.Text == "months")
            {
                dividorTime = 12;
            }
            else if (timeComboBox.Text == "quarters")
            {
                dividorTime = 4;
            }
            else if (timeComboBox.Text == "years")
            {
                dividorTime = 1;
            }
            return dividorTime;
        }


        Double calculateA ()
        {
            double P, R, t,A,r,time,T;

            P = double.Parse(textBox1.Text);
            R = double.Parse(textBox2.Text);
            t = double.Parse(textBox3.Text);
            //T = double.Parse(timeComboBox.Text);
            r = R / 100;
            time = t / timeMeasure();
            A = P * (1 + r * time);
            return A;
        }

        Double calculatePrinciple()
        {
            double P, R, t, A, r, time, T;
            A = double.Parse(textBox1.Text);
            R = double.Parse(textBox2.Text);
            t = double.Parse(textBox3.Text);
            r = R / 100;
            time = t / timeMeasure();
            P = A / (1 + r * time);

            return P;

        }

        string calculateRate()
        {
            double  R, t, A, r, rate, rPercentile;
            string return_rate;
            A = double.Parse(textBox1.Text);
            R = double.Parse(textBox2.Text);
            t = double.Parse(textBox3.Text);
            r = (1/t) * ((100/20)-1);
            rPercentile = (r * 100);
            rate = rPercentile* timeMeasure();
            return_rate = "R = " + rPercentile + "%/" + timeComboBox.Text + "    " + "( R = " + rate + "%/Year )";
            return return_rate;
        }

        Double calculateTimePeriod()
        {
            double P, R, t, A, r, rate, T, rPercentile;
            A = double.Parse(textBox1.Text);
            P = double.Parse(textBox2.Text);
            R = double.Parse(textBox3.Text);
            r = R / 100;
            t = (1 / r) * ((A / P) - 1);
            return t;

        }

        void emptyTextBox()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            resultTextBox.Text = String.Empty;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (rulesComboBox.Text == "Total P+I (A)")
                {
                    resultTextBox.Text = "A = $" + calculateA();
                }
                else if (rulesComboBox.Text == "Principal (P)")
                {
                    resultTextBox.Text = "P = $" + calculatePrinciple();
                }
                else if (rulesComboBox.Text == "Rate (R)")
                {
                    resultTextBox.Text = calculateRate();
                }
                else if (rulesComboBox.Text == "Time Period (t)")
                {
                    resultTextBox.Text = "t = " + calculateTimePeriod();
                }

            }
            catch(FormatException)
            {
                MessageBox.Show("Enter missing values");
            }



        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            emptyTextBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
