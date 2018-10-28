using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gugundabattulaProject3A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class startwithsix : Exception
        {


            public startwithsix()
            {
                MessageBox.Show("An exception has occured the number cannot start with 6 for the first number");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = maskedTextBox1.Text;
                decimal Number1 = Convert.ToDecimal(maskedTextBox1.Text);
                decimal Number2 = Convert.ToDecimal(maskedTextBox2.Text);
                decimal number3 = Number1 / Number2;
                if (Number1 > 5000)
                {
                    throw new OverflowException();
                };
                if (a.StartsWith("6"))
                {
                    throw new startwithsix();
                }
                maskedTextBox3.Text = number3.ToString();
                maskedTextBox1.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Format Exception has occured enter values in numbers only");
                maskedTextBox1.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow exception has occured enter First Number less then 5000");
                maskedTextBox1.Focus();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Divide by zero exception has occured enter a number greater than zero for Second Number");
                maskedTextBox2.Focus();
            }
            catch (startwithsix)
            {
                maskedTextBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
