using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W5.T1.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label1.Text.Length >= 0)
            {
                label1.Text = "You pressed a button!";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            MessageBox.Show("You cleared the label");
        }
    }
}
