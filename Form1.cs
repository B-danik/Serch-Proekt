using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serch_String
{
    public partial class Form1 : Form
    {
        private string[] str;

        public Form1()
        {
            InitializeComponent();
      
        }
     
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            String with = Convert.ToString(richTextBox1.Text);
            String what = Convert.ToString(richTextBox2.Text);
            int count = 0;
            char[] n = with.ToCharArray();
            char[] m = what.ToCharArray();


            for (int i = 0; i <= n.Length - m.Length; i++)
            {
                for (int j = 0; j < m.Length; j++)
                {
                    if (n[i + j] == m[j])
                    {
                        count++;
                        if (count == m.Length)
                        {
                            MessageBox.Show("Nice");
                            richTextBox1.SelectionStart = richTextBox1.TextLength;
                            richTextBox1.SelectionLength = 0;
                            richTextBox1.SelectionColor = Color.Red;
                            richTextBox1.AppendText(Environment.NewLine + what);
                            richTextBox1.SelectionColor = richTextBox1.ForeColor;

                            //string mystring = @"my first string";
                            //if (richTextBox1.Find(n) > 0)
                            //{
                            //    int my1stPosition = richTextBox1.Find(what);
                            //    richTextBox1.SelectionStart = my1stPosition;
                            //    richTextBox1.SelectionLength = with.Length;
                            //    richTextBox1.SelectionColor = Color.Red;
                            //}
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
        }
    }
}
