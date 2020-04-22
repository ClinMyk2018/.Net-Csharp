using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W2.T2.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String num1 = textBox1.Text;
            String num2 = textBox2.Text;

            int result = Convert.ToInt32(num1) + Convert.ToInt32(num2);

            label1.Text = result.ToString();
        }
    }
}
