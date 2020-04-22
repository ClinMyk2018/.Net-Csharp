using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3.T6.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack st1 = new Stack();
        Queue q1 = new Queue();

        private void Form1_Load(object sender, EventArgs e)
        {
            st1.Push("Number");
            st1.Push(27);
            st1.Push("Word");
            st1.Push("Tubig");

            foreach (var v in st1)
            {
                listBox1.Items.Add(v.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();

                foreach (var v in st1)
                {
                    q1.Enqueue(v);
                    listBox2.Items.Add(v.ToString());
                }
                
                st1.Clear();
            } else if (listBox2.Items.Count != 0) 
            {
                listBox2.Items.Clear();

                foreach (var v in q1)
                {
                    st1.Push(v);
                    listBox1.Items.Add(v.ToString());
                }

                q1.Clear();
            }
        }

    }
}
