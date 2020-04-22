using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3.T2.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] names = new string[15];
            names[0] = "Abby Mallard";
            names[1] = "Abigail Gabble";
            names[2] = "Abis Mal";
            names[3] = "Abu";
            names[4] = "Adella";
            names[5] = "The Agent";
            names[6] = "Agent Wendy Pleakley";
            names[7] = "Ajax the Gorilla";
            names[8] = "Akela";
            names[9] = "Al the Alligator";
            names[10] = "Aladar";
            names[11] = "Aladdin";
            names[12] = "Brad Caleb";
            names[13] = "Alameda Slim";
            names[14] = "Alice";
            Array newNames = Array.CreateInstance(typeof(String), 15);

            foreach (String name in names)
            {
                names.CopyTo(newNames, 0);
            }
            foreach (String newname in newNames)
            {
                listBox1.Items.Add(newname);
            }
        }
    }
}
