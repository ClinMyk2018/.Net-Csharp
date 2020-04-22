using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W5.T2.ClinardMykal
{
    public partial class Form1 : Form
    {

        private void Log_message(string msg)
        {

            StreamWriter log;
            if (!File.Exists("logfile.txt"))
            {
                log = new StreamWriter("logfile.txt");
            }
            else
            {
                log = File.AppendText("logfile.txt");
            }
            //Write some messages
            log.WriteLine(msg);
            log.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
                {
                MessageBox.Show("Your form is in!");
                }
            else
                {
                MessageBox.Show("Please fill out all of the boxes!");
               
                }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                {

                    throw new System.ArgumentException("No Numbers or Spaces Allowed");
                }
            }
            catch (System.ArgumentException ex)
            {
                Log_message("This error was: " + ex.Message);
                e.Handled = true;
                label5.Text = ex.Message;
            } 
            finally
            {
                if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {
                    label5.Text = "";
                }
            }
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                {

                    throw new System.ArgumentException("No Numbers or Spaces Allowed");
                }
            }
            catch (System.ArgumentException ex)
            {
                Log_message("This error was: " + ex.Message);
                e.Handled = true;
                label5.Text = ex.Message;
            }
            finally
            {
                if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {
                    label5.Text = "";
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                {

                    throw new System.ArgumentException("No Letters or Spaces Allowed");
                }
            }
            catch (System.ArgumentException ex)
            {
                Log_message("This error was: " + ex.Message);
                e.Handled = true;
                label5.Text = ex.Message;
            }
            finally
            {
                if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {
                    label5.Text = "";
                }
            }
        }

    }
}
