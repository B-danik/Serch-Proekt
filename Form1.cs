using System;
using System.Drawing;
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
        private void button3_Click(object sender, EventArgs e)
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

                            string mystring = @"my first string";
                            if (richTextBox1.Find(n) > 0)
                            {
                                int my1stPosition = richTextBox1.Find(what);
                                richTextBox1.SelectionStart = my1stPosition;
                                richTextBox1.SelectionLength = with.Length;
                                richTextBox1.SelectionColor = Color.Red;
                            }


                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sample = richTextBox2.Text;
            string basic = richTextBox1.Text;

            int[] samplePrefis = new int[sample.Length];
            prefix_function(sample, samplePrefis);

            int i = 0;
            int j = 0; 
            while (true)
            {
                if (basic[i] == sample[j])
                {
                    i++;j++;
                    if (j == sample.Length - 1)
                    {
                        MessageBox.Show("Well done!!!");
                        break;
                    }
                }
                else
                {
                    if (j > 0)
                    {
                        j = samplePrefis[j - 1];
                    }
                    else i++;
                    if(i== basic.Length)
                    {
                        MessageBox.Show("No found!!!");
                    }
                }
            }
        }
        private void prefix_function(string sample, int[] samplePrefis)
        {
            samplePrefis[0] = 0;
            int j = 0;
            int i = 1;
            while (i < sample.Length)
            {
                if (sample[i] != sample[j])
                {
                    if (j == 0)
                    {
                        samplePrefis[i++] = 0;
                    }
                    else
                    {
                        j = samplePrefis[j - 1];
                    }
                }
                else
                {
                    samplePrefis[i] = j + 1;
                    i++;
                    j++;
                }
            }
        }
        private void genText()
        {
            const string letterSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSRUVWXYZ      ";

        }
    }
}
