using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gundabattulaProject3B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = maskedTextBox1.Text;
            for (int i = 0; i <= a.Length; i++)
            {
                a = a.Replace("$", "");
                a = a.Replace("@", "");
                a = a.Replace("#", "");
                a = a.Replace("%", "");
                a = a.Replace("&", "");
                a = a.Replace("^", "");
                a = a.Replace("*", "");
                a = a.Replace("[", "");
                a = a.Replace("]", "");
                a = a.Replace("/", "");
            }
            maskedTextBox1.Text = a;
            string b = maskedTextBox2.Text;
            if (b.StartsWith(" ") || b.StartsWith("$") || b.StartsWith("@") || b.StartsWith("%") || b.StartsWith("#")|| b.StartsWith("The") || b.StartsWith("Joe"))
            {
                MessageBox.Show("The string2 can't start with a space or $ or @ or % or # or The or Joe");
                maskedTextBox2.Clear();
                maskedTextBox2.Focus();
            }
            string c = maskedTextBox3.Text;
            if (c.EndsWith("0") || c.EndsWith("1") || c.EndsWith("2") || c.EndsWith("3") || c.EndsWith("4") || c.EndsWith("5") || c.EndsWith("6") || c.EndsWith("7"))
            {
                MessageBox.Show("The string3 can't End with 0, 1, 2, 3, 4, 5, 6, 7");
                maskedTextBox3.Clear();
                maskedTextBox3.Focus();

            }

        }
    }
}
