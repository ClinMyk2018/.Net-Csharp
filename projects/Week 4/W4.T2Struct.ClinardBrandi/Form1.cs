using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4.T2Struct.ClinardBrandi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct InitialStruct
        {
            public String txt;
        }
        InitialStruct Struct1 = new InitialStruct();
        InitialStruct Struct2 = new InitialStruct();

        private void button1_Click(object sender, EventArgs e)
        {
            Struct1.txt = textBox1.Text;
            Struct2.txt = textBox2.Text;
            textBox3.Text = String.Concat(Struct1.txt, Struct2.txt);
        }
    }
}
