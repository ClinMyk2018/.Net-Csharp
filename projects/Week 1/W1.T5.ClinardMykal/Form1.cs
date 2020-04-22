using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1.T5.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            int[] smallArray = new int[] { 1, 3, 4, 7 };
            foreach (int num in smallArray)
            {
                MessageBox.Show("This is " + num);
                while (num == 7)
                {
                    labelTwo.Text = "Press Me";
                    break;
                }
            }

        }

        private void labelTwo_Click(object sender, EventArgs e)
        {
            if (labelTwo.Text == "Press Me")
            {
                for (int i = 1; i <= 3; i++)
                {
                    string myString = i.ToString();
                    MessageBox.Show(myString);
                    if (i == 2)
                    {
                        labelOne.Text = "It Is Over";
                    }
                    else if (i == 3)
                    {

                        do
                        {
                            Label mylab1 = new Label();
                            mylab1.Text = "  HELLO!!!!!  ";
                            mylab1.Location = new Point(350, 200);
                            mylab1.AutoSize = true;
                            mylab1.BorderStyle = BorderStyle.Fixed3D;
                            mylab1.Font = new Font("Calibri", 18);
                            mylab1.Padding = new Padding(6);

                            this.Controls.Add(mylab1);
                            break;
                        } while (labelOne.Text == "It Is Over");
                        
                    }
                }
            }
        }
        
    }
}
