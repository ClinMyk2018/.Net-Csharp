using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W2.T1.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String t = "Tarja";

        private void button1_Click(object sender, EventArgs e)
        {
            string turenen = t;
            textBox1.Text = turenen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string girl_that_sings = t;
            textBox2.Text = girl_that_sings;
        }
    }
}
