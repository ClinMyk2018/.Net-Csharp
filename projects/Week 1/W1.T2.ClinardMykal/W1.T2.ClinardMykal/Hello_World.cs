using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1.T2.ClinardMykal
{
    public partial class frmHello_World : Form
    {
        public frmHello_World()
        {
            InitializeComponent();
        }

        private void frmHello_World_Load(object sender, EventArgs e)
        {
            lblHello_World_Display.Text = "Hello World";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHello_World_Display.Text = "Good-Bye World";
            /*if (lblHello_World_Display.Text == "Hello World")
            {
                lblHello_World_Display.Text = "Good-Bye World";
            }
            else if (lblHello_World_Display.Text == "Good-Bye World")
            {
                lblHello_World_Display.Text = "Hello World";
            }*/
        }
    }
}
