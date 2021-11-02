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
    public partial class Length : UserControl
    {
        public Length()
        {
            InitializeComponent();
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

        private void Converter(string conVal)
        {
            switch (conVal)
            {
                case "Kilometre":
                    this.textBox1.Text = (long.Parse(LabelCurrent.Text) * 1000).ToString()+" m";
                    this.textBox2.Text = (long.Parse(LabelCurrent.Text) * 100000).ToString() + " cm";
                    this.textBox3.Text = (long.Parse(LabelCurrent.Text) * 0.621371).ToString() + " mi";
                    this.textBox4.Text = (long.Parse(LabelCurrent.Text) * 3280.84).ToString() + " ft";
                    this.textBox5.Text = (long.Parse(LabelCurrent.Text) * 1093.61).ToString() + " yd";
                    break;
                case "Metre":
                    this.textBox1.Text = (long.Parse(LabelCurrent.Text) / 1000).ToString() + " km";
                    this.textBox2.Text = (long.Parse(LabelCurrent.Text) * 100).ToString() + " cm";
                    this.textBox3.Text = (long.Parse(LabelCurrent.Text) / 0.000621371).ToString() + " mi";
                    this.textBox4.Text = (long.Parse(LabelCurrent.Text) * 3.28084).ToString() + " ft";
                    this.textBox5.Text = (long.Parse(LabelCurrent.Text) * 1.09361).ToString() + " yd";
                    break;
                case "Centimetre":
                    this.textBox1.Text = (long.Parse(LabelCurrent.Text) / 100000).ToString() + " km";
                    this.textBox2.Text = (long.Parse(LabelCurrent.Text) / 100).ToString() + " m";
                    this.textBox3.Text = (long.Parse(LabelCurrent.Text) / 160934).ToString() + " mi";
                    this.textBox4.Text = (long.Parse(LabelCurrent.Text) / 30.48).ToString() + " ft";
                    this.textBox5.Text = (long.Parse(LabelCurrent.Text) / 91.44).ToString() + " yd";
                    break;
                case "Mile":
                    this.textBox1.Text = (long.Parse(LabelCurrent.Text) * 1.60934).ToString() + " km";
                    this.textBox2.Text = (long.Parse(LabelCurrent.Text) * 1609.34).ToString() + " m";
                    this.textBox3.Text = (long.Parse(LabelCurrent.Text) * 160934).ToString() + " cm";
                    this.textBox4.Text = (long.Parse(LabelCurrent.Text) * 5280).ToString() + " ft";
                    this.textBox5.Text = (long.Parse(LabelCurrent.Text)  * 1760).ToString() + " yd";
                    break;
                case "Foot":
                    this.textBox1.Text = (long.Parse(LabelCurrent.Text) / 3281).ToString() + " km";
                    this.textBox2.Text = (long.Parse(LabelCurrent.Text) / 3.281).ToString() + " m";
                    this.textBox3.Text = (long.Parse(LabelCurrent.Text) * 30.48).ToString() + " cm";
                    this.textBox4.Text = (long.Parse(LabelCurrent.Text) / 5280).ToString() + " mi";
                    this.textBox5.Text = (long.Parse(LabelCurrent.Text) / 3).ToString() + " yd";
                    break;
                case "Yard":
                    this.textBox1.Text = (long.Parse(LabelCurrent.Text) / 1094).ToString() + " km";
                    this.textBox2.Text = (long.Parse(LabelCurrent.Text) / 1.094).ToString() + " m";
                    this.textBox3.Text = (long.Parse(LabelCurrent.Text) * 91.44).ToString() + " cm";
                    this.textBox4.Text = (long.Parse(LabelCurrent.Text) / 1760).ToString() + " mi";
                    this.textBox5.Text = (long.Parse(LabelCurrent.Text) * 3).ToString() + " ft";
                    break;
            }
        }

        private void LabelCurrent_Click(object sender, EventArgs e)
        {
           
        }

        private void LabelCurrent_TextChanged(object sender, EventArgs e)
        {
            if (LabelCurrent.Text != "")
            {
                Converter(gunaComboBox1.Text);
                
            }
        }

        private void guna2CircleButton14_Click(object sender, EventArgs e)
        {
            if(LabelCurrent.Text != "")
            {
                LabelCurrent.Text = LabelCurrent.Text.Remove(LabelCurrent.Text.Length-1,1);
            }
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void Length_VisibleChanged(object sender, EventArgs e)
        {
            ClearAll();
            gunaComboBox1.Text = "";
        }

        private void ClearAll()
        {
            LabelCurrent.Text = "";
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
        }

        private void guna2CircleButton12_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }


   
}
