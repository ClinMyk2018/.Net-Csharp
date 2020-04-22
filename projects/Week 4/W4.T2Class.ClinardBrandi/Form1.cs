using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4.T2Class.ClinardBrandi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassEx classEx1 = new ClassEx
            {
                text = textBox1.Text
            };

            ClassEx classEx2 = new ClassEx
            {
                text = textBox2.Text
            };

            textBox3.Text = String.Concat(classEx1.text, classEx2.text);


        }
    }
}
