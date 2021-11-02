using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Temperature : UserControl
    {
        public Temperature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "1";
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "2";
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "3";
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "4";
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "5";
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "6";
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "7";
        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "8";
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "9";
        }

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {
            if (LabelCurrent.Text.Substring(0) != "")
                LabelCurrent.Text += "0";
        }

        private void guna2CircleButton11_Click(object sender, EventArgs e)
        {
            if(!LabelCurrent.Text.Contains(".") && LabelCurrent.Text !="")
            LabelCurrent.Text += ".";
        }

        private void guna2CircleButton12_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text = gunaTextBox1.Text = null;
        }

        private void guna2CircleButton14_Click(object sender, EventArgs e)
        {
            if (LabelCurrent.Text != "") 
            {

                LabelCurrent.Text = LabelCurrent.Text.Substring(0,LabelCurrent.Text.Length - 1);
                if (LabelCurrent.Text == "-")
                {
                   LabelCurrent.Text = LabelCurrent.Text.Remove(0, 1);
                }
            }
          
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gunaComboBox2.Items.Clear();
            LabelCurrent.Text = "";

            // items for gunaComboBox2
            string[] comboItems = { "Celcius    (°C)", "Fahrenheit (°F)", "Kelvin  (K)" };

            // statements that  checks wether an items exist in combobox1.text
            for (int i = 0; i < comboItems.Length; i++)
            {
                if (gunaComboBox1.Text != comboItems[i])
                {
                    gunaComboBox2.Items.Add(comboItems[i]);
                }

            }

          
       
        }

        private void LabelCurrent_TextChanged(object sender, EventArgs e)
        {
            if (gunaComboBox1.Text != "" && gunaComboBox2.Text != "" && LabelCurrent.Text != "" && LabelCurrent.Text !="-")
            {
                TempConverter(LabelCurrent.Text,gunaComboBox1.Text,gunaComboBox2.Text);
            }
        }

        private void TempConverter(string input,string temp,string tempConverted)
        {
            switch (temp)
            {
                case "Fahrenheit (°F)":
                    if (tempConverted == "Celcius    (°C)")
                    {
                        gunaTextBox1.Text = ((float.Parse(input) - 32) * 5/9).ToString();
                        gunaTextBox1.Text += " °C";
                    }
                    else
                    {
                        gunaTextBox1.Text =((float.Parse(input) - 32) * 5/9 +273.15).ToString();
                        gunaTextBox1.Text += " K";
                    }
                    break;
                case "Celcius    (°C)":
                    if (tempConverted == "Fahrenheit (°F)")
                    {
                        gunaTextBox1.Text = ((float.Parse(input) * 9/5) + 32).ToString();
                        gunaTextBox1.Text += " °F";
                    }
                    else
                    {
                        gunaTextBox1.Text = (float.Parse(input) + 273.15).ToString();
                        gunaTextBox1.Text += " K";
                    }
                    break;
           
                case "Kelvin  (K)":
                    if (tempConverted == "Fahrenheit (°F)")
                    {
                        gunaTextBox1.Text = ((float.Parse(input)-273.15)*9/5+32).ToString();
                        gunaTextBox1.Text += " °F";
                    }
                    else
                    {
                        gunaTextBox1.Text = (float.Parse(input) - 273.15).ToString();
                        gunaTextBox1.Text += " °C";
                    }
                    break;
            }
        }

        private void LabelCurrent_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton13_Click(object sender, EventArgs e)
        {
            if(!LabelCurrent.Text.Contains("-") && LabelCurrent.Text !="")
          LabelCurrent.Text = LabelCurrent.Text.Insert(0, "-");
            else if(LabelCurrent.Text.Contains("-") && LabelCurrent.Text != "")
            {
                LabelCurrent.Text = LabelCurrent.Text.Remove(0,1);
            }
        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void Temperature_VisibleChanged(object sender, EventArgs e)
        {
            ClearAll();
            gunaComboBox1.Text = gunaComboBox2.Text = "";
        }

        private void ClearAll()
        {
            LabelCurrent.Text = "";
            gunaTextBox1.Text = "";
        }
    }
}
