using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4.T2Class.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox t1 = new TextBox
            {
                Text = textBox1.Text
            };

            TextBox t2 = new TextBox
            {
                Text = textBox2.Text
            };

            textBox3.Text = String.Concat(t1.Text, t2.Text);

        }
    }
}
