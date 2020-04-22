using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W2.T4.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1, result;
        int controlType;

        private void butC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            controlType = 0;
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            controlType = 1;
        }

        private void butMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                //Console.WriteLine(num1);
                textBox1.Clear();
                textBox1.Focus();
                controlType = 2;
            } else
            {
                textBox1.Text = "-";
            }
        }

        private void butMultiply_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            controlType = 3;
        }

        private void butDivide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            controlType = 4;
        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            resultCalc(controlType);
        }
        public void resultCalc(int controlType)
        {
            switch (controlType)
            {
                case 1:
                    result = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;
                case 2:
                    result = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;
                case 3:
                    result = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;
                case 4:
                    result = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void but1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void but2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void but3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void but4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void but5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void but6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void but7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void but8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void but9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void butDecimal_Click(object sender, EventArgs e)
        {
            int currentTextBoxValueLength = textBox1.TextLength;
            int flagDecimal = 0;
            string currentTextBoxValue = textBox1.Text;
            for (int i = 0; i < currentTextBoxValueLength; i++)
            {
                if (currentTextBoxValue[i].ToString() == ".")
                {
                    flagDecimal = 1; break;
                }
                else
                {
                    flagDecimal = 0;
                }
            }
            if (flagDecimal == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }
    }
}
