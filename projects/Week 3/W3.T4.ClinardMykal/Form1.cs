using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3.T4.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack<Int32> st = new Stack<Int32>();
        Int32 val = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int x = 1; x <= 10; x++)
            {
                val *= 2;
                st.Push(val);
            }
            foreach (Int32 v in st)
            {
                listBox1.Items.Add(v.ToString());
            }
            foreach (Int32 rv in st.Reverse())
            {
                listBox2.Items.Add(rv.ToString());
            }
        }
       
    }
}
