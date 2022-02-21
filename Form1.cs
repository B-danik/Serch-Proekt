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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            String with = Convert.ToString(rtb_Basic.Text);
            String what = Convert.ToString(rtb_sample.Text);
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
                            rtb_Basic.SelectionStart = rtb_Basic.TextLength;
                            rtb_Basic.SelectionLength = 0;
                            rtb_Basic.SelectionColor = Color.Red;
                            rtb_Basic.AppendText(Environment.NewLine + what);
                            rtb_Basic.SelectionColor = rtb_Basic.ForeColor;

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

        private void btn_KMP_Click(object sender, EventArgs e)
        {
            int numRow = 0;
            dgv.Visible = false;
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            string sample = rtb_sample.Text;
            string basic = rtb_Basic.Text;

            int[] samplePrefis = new int[sample.Length];
            prefix_function(sample, samplePrefis);
            for (int a = 0; a < basic.Length; a++)
            {
                dgv.Columns.Add("DGV1", Convert.ToString(basic[a]));
                dgv.Columns[a].Width = dgv.Width / 20;
            }
            int i = 0;
            int j = 0;
            bool flagEnter = true;
            while (true)
            {
                if (flagEnter)
                {
                    dgv.Rows.Add();
                    for (int a = i - j, k = 0; k < sample.Length; k++, a++)
                    {
                        dgv[a, numRow].Value = sample[k];
                    }
                    numRow++;
                    flagEnter = false;
                }
                if (basic[i] == sample[j])
                {

                    if (j == sample.Length - 1)
                    {
                        MessageBox.Show("Well done!!!");
                        break;
                    }
                    i++; j++;
                    
                    
                }
                else
                {
                    if (j > 0)
                    {
                        j = samplePrefis[j - 1];
                        
                    }
                    else
                    {
                        
                        i++;
                        
                    }

                    if (i == basic.Length)
                    {
                        MessageBox.Show("No found!!!");
                        break;
                    }
                }
                

            }
            dgv.Visible = true;
        }
    }
}
