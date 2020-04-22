using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3.T3.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stack<Int32> st = new Stack<Int32>();
            Int32 val = 1;
            for (int x = 1; x <= 20; x++)
            {
                val *= 2;
                st.Push(val);
            }
            foreach (Int32 v in st)
            {
                listBox1.Items.Add(v.ToString());
            }
        }
    }
}
