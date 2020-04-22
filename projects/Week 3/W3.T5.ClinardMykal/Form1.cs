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

namespace W3.T5.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue collection1 = new Queue();

        private void Form1_Load(object sender, EventArgs e)
        {
            collection1.Enqueue("Lets Start");
            listBox1.Items.Add(collection1.Peek());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            collection1.Enqueue("Hello");
            collection1.Enqueue("We");
            collection1.Enqueue("Added");
            collection1.Enqueue("Something");

            foreach (var value in collection1)
            {
                listBox1.Items.Add(value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (collection1.Count != 0)
            {
                collection1.Dequeue();
            }

            foreach (var value in collection1)
            {
                listBox1.Items.Add(value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            collection1.Clear();
            collection1.Enqueue("You cleared everything!");

            foreach (var value in collection1)
            {
                listBox1.Items.Add(value.ToString());
            }
        }
    }
}
