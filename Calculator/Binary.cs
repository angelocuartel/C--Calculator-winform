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
    public partial class Binary : UserControl
    {

        private string binary = "";

        public Binary()
        {
            InitializeComponent();
        }

        private void BinaryConverter_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
    
        }

        private void ConvertToBinary(string calculate)
        {
            int decVal = Convert.ToInt32(calculate);
            while(decVal > 0)
            {
                binary += Convert.ToString(decVal % 2);
                decVal = decVal / 2;
            }
        }

        private string BinaryReverse(string binary)
        {
            string newBinary = "";
           for(int i = 1; i<=binary.Length; i++)
            {
                newBinary += binary.Substring(binary.Length-i,1);
            }
            this.binary = "";
            return newBinary;
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "9";
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "6";
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // pre statement that restart the itemList in comboBox2
            gunaComboBox2.Items.Clear();
            LabelCurrent.Text = "";

            // items for gunaComboBox2
            string[] comboItems = {"Decimal","Binary","HexaDecimal"};

            // statements that  checks wether an items exist in combobox1.text
            for(int i = 0; i < comboItems.Length; i++)
            {
               if(gunaComboBox1.Text != comboItems[i])
                {
                    gunaComboBox2.Items.Add(comboItems[i]);
                }
              
            }
            guna2CircleButton2.Enabled = guna2CircleButton3.Enabled = guna2CircleButton4.Enabled = guna2CircleButton5.Enabled = guna2CircleButton6.Enabled = guna2CircleButton7.Enabled = guna2CircleButton8.Enabled = guna2CircleButton9.Enabled = true;
            guna2CircleButton11.Enabled = guna2CircleButton15.Enabled = guna2CircleButton16.Enabled = guna2CircleButton13.Enabled = guna2CircleButton17.Enabled = guna2CircleButton18.Enabled = false;
            if (gunaComboBox1.Text == "HexaDecimal")
            {
                guna2CircleButton11.Enabled = guna2CircleButton15.Enabled = guna2CircleButton16.Enabled = guna2CircleButton13.Enabled = guna2CircleButton17.Enabled = guna2CircleButton18.Enabled = true;
            }
            else if(gunaComboBox1.Text == "Decimal")
            {
                guna2CircleButton11.Enabled = guna2CircleButton15.Enabled = guna2CircleButton16.Enabled = guna2CircleButton13.Enabled = guna2CircleButton17.Enabled = guna2CircleButton18.Enabled = false;
            }

          else if(gunaComboBox1.Text == "Binary")
            {
                guna2CircleButton2.Enabled = guna2CircleButton3.Enabled = guna2CircleButton4.Enabled = guna2CircleButton5.Enabled = guna2CircleButton6.Enabled = guna2CircleButton7.Enabled = guna2CircleButton8.Enabled = guna2CircleButton9.Enabled = guna2CircleButton17.Enabled = guna2CircleButton18.Enabled = false;

            }
            else
            {
                guna2CircleButton2.Enabled = guna2CircleButton3.Enabled = guna2CircleButton4.Enabled = guna2CircleButton5.Enabled = guna2CircleButton6.Enabled = guna2CircleButton7.Enabled = guna2CircleButton8.Enabled = guna2CircleButton9.Enabled = guna2CircleButton17.Enabled = guna2CircleButton18.Enabled = true;
            }

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

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "7";
        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "8";
        }

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {
            if (LabelCurrent.Text.Substring(0) != "" || gunaComboBox1.Text == "Binary")
                LabelCurrent.Text += "0";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            // takes the combobox2 text and compare it then converts it accordingly to the string
            if (gunaComboBox2.Text != "")
            {
                switch (gunaComboBox1.Text)
                {
                    case "Binary":
                        gunaTextBox1.Text = BinaryDecHex(LabelCurrent.Text, gunaComboBox2.Text);
                        break;
                    case "Decimal":
                        if (gunaComboBox2.Text == "Binary")
                        {
                            gunaTextBox1.Text = Convert.ToString(Convert.ToInt64(LabelCurrent.Text), 2);
                        }
                        else
                        {
                            gunaTextBox1.Text = Convert.ToString(Convert.ToInt64(LabelCurrent.Text), 16);
                        }
                        break;
                    case "HexaDecimal":
                        gunaTextBox1.Text = HexDecBinary(LabelCurrent.Text, gunaComboBox2.Text);
                        break;
                }

            }
            else
            {
                MessageBox.Show("Please Select a Numeral System to be Converted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "1";
        }

        private void guna2CircleButton12_Click(object sender, EventArgs e)
        {
            // clears all input 
            LabelCurrent.Text= "";
            gunaTextBox1.Text = "";

        }

        private void guna2CircleButton14_Click(object sender, EventArgs e)
        {
            //remove the recent input
            if(LabelCurrent.Text != "")
                LabelCurrent.Text = LabelCurrent.Text.Substring(0,LabelCurrent.Text.Length-1);
        }

        private void guna2CircleButton15_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "a";
        }

        private void guna2CircleButton13_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "b";
        }

        private void guna2CircleButton16_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "c";
        }

        private void guna2CircleButton11_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "d";
        }

        private string BinaryDecHex(string binaryVal,string numeralSys)
        {
            double decimalVal = 0;
            string hexVal = "";
            //binary to decimal
           for(int dec = 0; dec < binaryVal.Length;dec++)
            {
                decimalVal += Convert.ToInt32(binaryVal.Substring((binaryVal.Length - 1) - dec, 1)) * (Math.Pow(2,dec));
            }
            int decimalVal2 = (int)decimalVal;
            // decimal to hexadecimal
            while (decimalVal2 > 1)
            {
                hexVal += HexLetters(Convert.ToString((decimalVal2 % 16)));
                decimalVal2 = decimalVal2 / 16;
            }
            if(numeralSys == "Decimal")
            {
                return decimalVal.ToString();
            }
            else
            {
                return Reverse(hexVal);
            }

        }

        private string HexLetters(string letter)
        {
            switch (letter)
            {
                case "10":
                    return "a";
                case "11":
                    return "b";
                case "12":
                    return "c";
                case "13":
                    return "d";
                case "14":
                    return "e";
                case "15":
                    return "f";
                default:
                    return letter;

            }
          
        }

        private string HexDecBinary(string hexadecimal,string numSys)
        {
            //hex converts to decimal
            double addValues = 0;
            for(int i = 0; i < hexadecimal.Length; i++)
            {
                addValues +=Convert.ToInt32(ConvertHexLetters(hexadecimal.Substring((hexadecimal.Length - 1) - i, 1))) * (Math.Pow(16,i));
            }
                
            if(numSys == "Decimal")
            {
                return addValues.ToString();
            }
            else
            {
                return Convert.ToString((int)addValues, 2);
            }
        }

        private string ConvertHexLetters(string letters)
        {
            switch (letters)
            {
                case "a":
                    return "10";
                case "b":
                    return "11";
                case "c":
                    return "12";
                case "d":
                    return "13";
                case "e":
                    return "14";
                case "f":
                    return "15";
                default:
                    return letters;

            }
        }

        private string Reverse(string value)
        {
            string reverse = "";
            for(int i = 0; i< value.Length; i++)
            {
                reverse += value.Substring(value.Length - 1 - i, 1);
            }
            return reverse;
        }

        private void guna2CircleButton17_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "e";
        }

        private void guna2CircleButton18_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += "f";
        }

        private void guna2CircleButton19_Click(object sender, EventArgs e)
        {
            LabelCurrent.Text += ".";
        }

        private void Binary_VisibleChanged(object sender, EventArgs e)
        {
            LabelCurrent.Text = gunaTextBox1.Text = "";
            gunaComboBox1.Text = gunaComboBox2.Text= "";
        }

        private void LabelCurrent_Click(object sender, EventArgs e)
        {

        }

        private void LabelCurrent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
