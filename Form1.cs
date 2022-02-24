using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Serch_String
{
    public partial class Form1 : Form
    {    

        public Form1()
        {
            InitializeComponent();

        }

        private void btn_GenText_Click(object sender, EventArgs e)
        {
            string s = "", symb = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSRUVWXYZ             ";
            Random rnd = new Random();

            for (int i = 0; i < symb.Length; i++)
            {
                s += symb[rnd.Next(0, symb.Length)];
                rtb_Basic.Text = s;
            }
        }


        private void btn_straight_Click(object sender, EventArgs e)
        {
            String with = Convert.ToString(rtb_Basic.Text);
            String what = Convert.ToString(rtb_sample.Text);
            int count = 0;
            char[] n = with.ToCharArray();
            char[] m = what.ToCharArray();
            bool check = false;

            if (rtb_Basic.Text != "" && rtb_sample.Text != "")
            {
                Stopwatch time1 = new Stopwatch();
                time1.Start();
                for (int i = 0; i <= n.Length - m.Length; i++)
                {

                    for (int j = 0; j < m.Length; j++)
                    {
                        if (n[i + j] == m[j])
                        {
                            count++;
                            if (count == m.Length)
                            {
                                check = true;
                                MessageBox.Show("Nice");
                                rtb_Basic.SelectionStart = rtb_Basic.TextLength;
                                rtb_Basic.SelectionLength = 0;
                                rtb_Basic.SelectionColor = Color.Red;
                                rtb_Basic.AppendText(Environment.NewLine + what);
                                rtb_Basic.SelectionColor = rtb_Basic.ForeColor;
                            }
                        }
                        else
                        {
                            count = 0;
                        }
                    }
                }
                time1.Stop();
                label_Time.Text = time1.ElapsedTicks.ToString();


                if (!check) MessageBox.Show("Текст не найден");
            }
            else MessageBox.Show("Введите текст");
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
        private void btn_KMP_Click(object sender, EventArgs e)
        {
            int numRow = 0;
            dgv.Visible = false;
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            string sample = rtb_sample.Text;
            string basic = rtb_Basic.Text;
            if (rtb_Basic.Text != "" && rtb_sample.Text != "")
            {
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
}
