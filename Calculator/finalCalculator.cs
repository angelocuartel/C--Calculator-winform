using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace Calculator
{
    public partial class finalCalculator : MetroFramework.Forms.MetroForm
    {
        public double? numStore = 0;
        public char operand = ' ', lastOperand = ' ';
        public string holder = "", lastString = "";
        public bool equalClick;
        bool hideShow = true;
        int panelWidth;

        public finalCalculator()
        {
            InitializeComponent();
            panelWidth = gunaPanel1.Width;

        }

        private void finalCalculator_Load(object sender, EventArgs e)
        {
            

        }

      private void ShowHideMenu(int index)
        {
            List<UserControl> menu = new List<UserControl>();
            menu.Add(calculator1);
            menu.Add(binary1);
            menu.Add(temperature1);
            menu.Add(length1);
            for (int i = 0; i < menu.Count; i++)
            {
                menu[i].Visible = false;
            }
            menu[index].Visible = true;

        }
        // a method that close if a 
        private void CloseMenu()
        {

            if (hideShow)
            {
                gunaAnimateWindow2.Start();
                gunaPanel1.Visible = true;
                hideShow = false;

            }
            else
            {
                timer1.Start();
            }
            gunaPanel1.Focus();
        }
   
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            CloseMenu();
            

        }

        private void finalCalculator_Load_1(object sender, EventArgs e)
        {
            
            gunaAnimateWindow1.Start();
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            ShowHideMenu(0);
            CloseMenu();
        }

        private void binary1_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            ShowHideMenu(1);
            CloseMenu();
        }

        private void calculator1_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            ShowHideMenu(2);
            CloseMenu();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            About2 about = new About2();
            about.ShowDialog();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            ShowHideMenu(3);
            CloseMenu();
        }

  

        private void gunaPanel1_MouseCaptureChanged(object sender, EventArgs e)
        {
            CloseMenu();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            gunaPanel1.Width = gunaPanel1.Width-20;

            if(gunaPanel1.Width <= 0)
            {
                gunaPanel1.Width = panelWidth;
                gunaPanel1.Visible = false;
                hideShow = true;
                this.Refresh();
                timer1.Stop();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
           

        }

      


       

      
 

    
   }
}


