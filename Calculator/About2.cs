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
    public partial class About2 : Form
    {
        public About2()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void About2_Load(object sender, EventArgs e)
        {
            gunaAnimateWindow1.Start();
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}
