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
    public partial class calculator : UserControl
    {
        private double? numStore = 0;
        private char operand = ' ', lastOperand = ' ';
        private string holder = "", lastString = "";
        private bool equalClick;
        public calculator()
        {
            InitializeComponent();
         


        }



        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {


            LabelCurrent.Text = holder += "5";


        }

        private void guna2CircleButton18_Click(object sender, EventArgs e)
        {
            CalFuntion('-');
        }

        private void guna2CircleButton1_Click1(object sender, EventArgs e)
        {

            LabelCurrent.Text = holder += "1";
            MessageBox.Show("hello");
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            LabelCurrent.Text = holder += "2";
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {

            LabelCurrent.Text = holder += "3";
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {

            LabelCurrent.Text = holder += "4";
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {

            LabelCurrent.Text = holder += "6";
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {

            LabelCurrent.Text = holder += "7";
        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {

            LabelCurrent.Text = holder += "8";
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {

            LabelCurrent.Text = holder += "9";
        }

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {

            LabelCurrent.Text = holder += "0";
        }

     

        private void guna2CircleButton13_Click(object sender, EventArgs e)
        {
            if (holder != "")
            {
                LabelCurrent.Text = LabelCurrent.Text.Replace(holder, "");
                holder = "";
            }
        }

    
   

        private void guna2CircleButton16_Click(object sender, EventArgs e)
        {
            CalFuntion('+');
        }

        private void guna2CircleButton17_Click(object sender, EventArgs e)
        {
            CalFuntion('x');
        }

        private void guna2CircleButton19_Click(object sender, EventArgs e)
        {
            CalFuntion('÷');
        }

     
        


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(numStore);
        }

        private void guna2CircleButton2_Click_1(object sender, EventArgs e)
        {
            LabelCurrent.Text = holder += "2";
          

        }

        private void guna2CircleButton3_Click_1(object sender, EventArgs e)
        {
            LabelCurrent.Text = holder += "3";
        }

        private void guna2CircleButton4_Click_1(object sender, EventArgs e)
        {
            LabelCurrent.Text = holder += "4";
        }

        private void guna2CircleButton5_Click_1(object sender, EventArgs e)
        {
            LabelCurrent.Text = holder += "5";
        }

        private void guna2CircleButton6_Click_1(object sender, EventArgs e)
        {
            LabelCurrent.Text = holder += "6";
        }

        private void guna2CircleButton7_Click_1(object sender, EventArgs e)
        {
            LabelCurrent.Text = holder += "7";
        }

        private void guna2CircleButton8_Click_1(object sender, EventArgs e)
        {
            LabelCurrent.Text = holder += "8";
        }

        private void guna2CircleButton9_Click_1(object sender, EventArgs e)
        {
            LabelCurrent.Text = holder += "9";
        }

        private void guna2CircleButton10_Click_1(object sender, EventArgs e)
        {
            if(LabelCurrent.Text.Substring(0) != "")
            LabelCurrent.Text = holder += "0";
        }

        private void guna2CircleButton11_Click_1(object sender, EventArgs e)
        {
            if ((!holder.Contains(".")) && holder != "")
            {
                LabelCurrent.Text += ".";
                holder += ".";
            }
        }

        private void guna2CircleButton12_Click_1(object sender, EventArgs e)
        {
            holder = "";
            LabelComplt.Text = "";
            LabelCurrent.Text = "";
            textBox2.Text = "";
            numStore = 0;
            operand = ' ';
            lastOperand = ' ';
            equalClick = false;
            LabelComplt.Visible = true;
            LabelCurrent.Visible = true;
        }

        private void guna2CircleButton13_Click_1(object sender, EventArgs e)
        {

            if (holder != "")
            {
                LabelCurrent.Text = LabelCurrent.Text.Replace(holder, "");
                holder = "";
            }
        }

        private void guna2CircleButton14_Click_1(object sender, EventArgs e)
        {
            if (LabelCurrent.Text != "")
            {
                lastString = LabelCurrent.Text.Substring(LabelCurrent.Text.Length - 1);
                if (lastString != "+" && lastString != "x" && lastString != "÷" && lastString != "÷")
                {
                    LabelCurrent.Text = LabelCurrent.Text.Remove(LabelCurrent.Text.Length - 1);
                    if (holder != "")
                    {
                        holder = holder.Remove(holder.Length - 1);
                    }
                }

            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (operand != ' ' && holder != "")
            {
                switch (operand)
                {
                    case '+':
                        numStore += Convert.ToDouble(holder);
                        break;
                    case 'x':
                        numStore *= Convert.ToDouble(holder);
                        break;
                    case '-':
                        numStore -= Convert.ToDouble(holder);
                        break;
                    case '÷':
                        numStore /= Convert.ToDouble(holder);
                        break;

                }
                equalClick = true;
                textBox2.Text = Convert.ToString(numStore);
                lastOperand = operand = ' ';
                LabelCurrent.Text = LabelComplt.Text = "";
                holder = "";





            }
        }

        private void guna2CircleButton17_Click_1(object sender, EventArgs e)
        {
            CalFuntion('x');
        }

        private void guna2CircleButton18_Click_1(object sender, EventArgs e)
        {
            CalFuntion('-');
        }

        private void guna2CircleButton19_Click_1(object sender, EventArgs e)
        {
            CalFuntion('÷');
        }

        private void calculator_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void LabelCurrent_Click(object sender, EventArgs e)
        {
            
        }

        private void LabelComplt_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(numStore);
        }

        private void calculator_VisibleChanged(object sender, EventArgs e)
        {
            holder = "";
            LabelComplt.Text = "";
            LabelCurrent.Text = "";
            textBox2.Text = "";
            numStore = 0;
            operand = ' ';
            lastOperand = ' ';
            LabelCurrent.Visible = LabelComplt.Visible = true;
        }

     
        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            LabelCurrent.Text = holder += "1";
          
        }

  

      






        private void CalFuntion(char op)
        {
           
            if (!equalClick)
            {
                LabelCurrent.Text = "0";
            }
            LabelComplt.Text += holder;
           

            if (LabelComplt.Text != "")
            {
                lastString = LabelComplt.Text.Substring(LabelComplt.Text.Length - 1);
            }
            // if last string is not equals below operand will not run or display
            if (lastString != "x"
           && lastString != "+" && lastString != "-" && lastString != "÷" && lastString != "%")
            {
                // first input in the calculator (ex. 1+) 1 integer will be stored in var numStore and holder will be 0
                if (numStore == 0 && LabelComplt.Text != "")
                {
                    numStore = Convert.ToDouble(holder);
                    holder = "";
                    switch (op)
                    {
                        case '+':
                            operand = '+';
                            LabelComplt.Text += "+";
                            break;
                        case 'x':
                            operand = 'x';
                            LabelComplt.Text += "x";
                            break;
                        case '-':
                            operand = '-';
                            LabelComplt.Text += "-";
                            break;
                        case '÷':
                            operand = '÷';
                            LabelComplt.Text += "÷";
                            break;
                        case '%':
                            operand = '%';
                            LabelComplt.Text += "%";
                            break;
                    }

                }// if operand is same as input operand (ex. 1+1+1)
                else if (numStore != 0 && operand == op)
                {
                    switch (op)
                    {
                        case '+':
                            numStore += Convert.ToDouble(holder);
                            lastOperand = '+';
                            LabelComplt.Text += "+";
                            break;
                        case 'x':
                            numStore *= Convert.ToDouble(holder);
                            lastOperand = 'x';
                            LabelComplt.Text += "x";
                            break;
                        case '-':
                            numStore -= Convert.ToDouble(holder);
                            lastOperand = '-';
                            LabelComplt.Text += "-";
                            break;
                        case '÷':
                            numStore /= Convert.ToDouble(holder);
                            lastOperand = '÷';
                            LabelComplt.Text += "÷";
                            break;
                        case '%':
                            numStore %= Convert.ToDouble(holder);
                            lastOperand = '%';
                            LabelComplt.Text += "%";
                            break;
                    }
                    holder = "";

                }// if lastoperand is not the same is the last (ex. 1+2x5)
                else if (lastOperand != op || operand != op)
                {
                    switch (operand)
                    {
                        case 'x':
                            numStore *= Convert.ToDouble(holder);
                            LabelComplt.Text += op;
                            operand = op;
                            lastOperand = op;
                            break;
                        case '+':
                            numStore += Convert.ToDouble(holder);
                            LabelComplt.Text += op;
                            operand = op;
                            lastOperand = op;
                            break;
                        case '-':
                            numStore -= Convert.ToDouble(holder);
                            LabelComplt.Text += op;
                            operand = op;
                            lastOperand = op;
                            break;
                        case '÷':
                            numStore /= Convert.ToDouble(holder);
                            LabelComplt.Text += op;
                            operand = op;
                            lastOperand = op;
                            break;
                        case '%':
                            numStore %= Convert.ToDouble(holder);
                            LabelComplt.Text += op;
                            operand = op;
                            lastOperand = op;
                            break;

                    }
                    holder = "";

                }



            }

            if (equalClick && LabelCurrent.Text =="")
            {
                equalClick = false;
                LabelCurrent.Text = "";
                textBox2.Text = "";
                LabelComplt.Text =(numStore).ToString();
                switch (op)
                {
                    case '+':
                        LabelComplt.Text += "+";
                        operand = '+';
                        lastOperand = '+';
                        break;
                    case 'x':
                        LabelComplt.Text += "x";
                        operand = 'x';
                        lastOperand = 'x';
                        break;
                    case '-':
                        LabelComplt.Text += "-";
                        operand = '-';
                        lastOperand = '-';
                        break;
                    case '÷':
                        LabelComplt.Text += "÷";
                        operand = '÷';
                        lastOperand = '÷';
                        break;
                    case '%':
                        LabelComplt.Text += "%";
                        operand = '%';
                        lastOperand = '%';
                        break;
                }

            }
            else if(equalClick && LabelCurrent.Text != "")
            {
                equalClick = false;
                textBox2.Text = "";
                LabelComplt.Text = LabelCurrent.Text;
                numStore = Convert.ToInt32(LabelCurrent.Text);

                switch (op)
                {
                    case '+':
                        LabelComplt.Text += "+";
                        operand = '+';
                        lastOperand = '+';
                        break;
                    case 'x':
                        LabelComplt.Text += "x";
                        operand = 'x';
                        lastOperand = 'x';
                        break;
                    case '-':
                        LabelComplt.Text += "-";
                        operand = '-';
                        lastOperand = '-';
                        break;
                    case '÷':
                        LabelComplt.Text += "÷";
                        operand = '÷';
                        lastOperand = '÷';
                        break;
                    case '%':
                        LabelComplt.Text += "%";
                        operand = '%';
                        lastOperand = '%';
                        break;
                }
            }

        }
    }
}
