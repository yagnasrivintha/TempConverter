using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "C";
            //comboBox1.Items.Add("C");
            comboBox1.Items.Add("F");
            comboBox1.Items.Add("K");
            pictureBox1.Image = Properties.Resources.temperaturegauge_none;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string Fahrenheitvalue = "";
            try
            {
                if (!string.IsNullOrEmpty(comboBox1.Text))
                {
                    if (comboBox1.Text == "C")
                    {
                        decimal selectedval = numericUpDown1.Value;
                        Fahrenheitvalue = ((selectedval * 9 / 5) + 32).ToString();
                        label2.Text = Fahrenheitvalue + "F";
                        label3.Text = (selectedval + (Decimal)273.15).ToString("0.00") + "K";

                    }

                    else if (comboBox1.Text == "F")
                    {
                        decimal selectedval = numericUpDown1.Value;
                        Fahrenheitvalue = numericUpDown1.Value.ToString();
                        label2.Text = ((selectedval - 32) * 5 / 9).ToString("0.00") + "°C";
                        label3.Text = (((selectedval - 32) * 5 / 9) + (Decimal)273.15).ToString("0.00") + "K";
                    }

                    else if (comboBox1.Text == "K")
                    {
                        decimal selectedval = numericUpDown1.Value;
                        Fahrenheitvalue = ((selectedval - (Decimal)273.15) * 9 / 5 + 32).ToString();
                        label2.Text = (selectedval - (Decimal)273.15).ToString("0.00") + "°C";
                        label3.Text = Fahrenheitvalue + "F";

                    }
                    if (!string.IsNullOrWhiteSpace(Fahrenheitvalue))
                    {
                        decimal result = decimal.Parse(Fahrenheitvalue);
                        if (result > 95)
                            pictureBox1.Image = Properties.Resources.temperaturegauge_hot;
                        if (75 < result && result < 95)
                            pictureBox1.Image = Properties.Resources.temperaturegauge_warm;
                        if (55 < result && result < 75)
                            pictureBox1.Image = Properties.Resources.temperaturegauge_mild;
                        if (33 < result && result < 55)
                            pictureBox1.Image = Properties.Resources.temperaturegauge_cold;
                        if (result < 33)
                            pictureBox1.Image = Properties.Resources.temperaturegauge_warm;
                    }
                }
            }
            catch(Exception ex)
            {
                
                MessageBox.Show("value cant be 0");
            }
        }
    }
}
