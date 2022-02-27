using System;
using System.Collections.Generic;
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
            for (int i = 0; i < 20; i++)
            {
                s += symb[rnd.Next(0, symb.Length - 1)];
                rtb_Basic.Text = s;               
            }
        }


        private void btn_straight_Click(object sender, EventArgs e)
        {
            string sample = "";
            string basic = "";
            if (!startAlgoritm(ref basic,ref sample))
                return;

            int numRow = 0;
                         
            Stopwatch time1 = new Stopwatch();
            time1.Start();
            for (int i = 0; i <= basic.Length - sample.Length; i++)                    
            {
                dgv.Rows.Add();
                for (int j = 0; j < sample.Length; j++)
                {
                    dgv[i + j, numRow].Value = sample[j];

                    if (basic[i + j] == sample[j])
                    {

                        if (j == sample.Length-1)
                        {
                            dgv[i + j, numRow ].Style.BackColor = Color.Green;
                            MessageBox.Show("Well done");
                            return;
                        }
                        
                        dgv[i + j, numRow].Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        dgv[i + j, numRow].Style.BackColor = Color.Red;
                        break;
                    }                                  
                }
                numRow++;    
            }
            time1.Stop();
            label_Time.Text = time1.ElapsedTicks.ToString();

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
            string sample = "";
            string basic = "";
            if (!startAlgoritm(ref basic, ref sample))
                return;

            int numRow = 0;
            int shiftStart = 0;
            int[] samplePrefis = new int[sample.Length];
            prefix_function(sample, samplePrefis);

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
                    shiftStart = i - j;
                    numRow++;
                    flagEnter = false;
                }
                if (basic[i] == sample[j])
                {
                    if (j == sample.Length - 1)
                    {
                        MessageBox.Show("Well done!!!");
                        dgv[shiftStart + j, numRow - 1].Style.BackColor = Color.Green;
                        break;
                    }

                    dgv[shiftStart+j, numRow-1].Style.BackColor = Color.Yellow;
                    i++; j++;
                }

                else
                {
                    dgv[shiftStart+j, numRow-1].Style.BackColor = Color.Red;
                    flagEnter = true;
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
        }

        private void btn_ClearTextSample_Click(object sender, EventArgs e)
        {
            rtb_Basic.Clear();
        }

        private void btn_BM_Click(object sender, EventArgs e)
        {
            string sample = "";
            string basic = "";
            if (!startAlgoritm(ref basic, ref sample))
                return;

            var libSumbol = new List<char>();
            var libNum = new List<int>();

            getLib(sample, libSumbol, libNum);

            int length = sample.Length;
            int i = length - 1;
            int numRow = 0;

            while (i<basic.Length)
            {
               
                int k = 0;
                dgv.Rows.Add();
                int b = sample.Length;
                for (int a = i; b>0; b --, a--)
                {
                    dgv[a, numRow].Value = sample[b-1];
                }
                numRow++;
                for (int j = length-1; j>-1; j--)
                {
                    if (basic[i-k]!=sample[j])
                    {
                        dgv[i-k, numRow - 1].Style.BackColor = Color.Red;
                        int shift;
                        if (j==length-1)
                        {
                            int index=libSumbol.IndexOf(basic[i]);
                            shift = index != -1 ? libNum[index] : length;
                        }
                        else
                        {
                            int index = libSumbol.IndexOf(sample[j]);
                            shift = libNum[index];
                        }
                        i+=shift;
                        break;
                    }
                    else
                    {
                        dgv[i-k, numRow - 1].Style.BackColor = Color.Yellow;
                    }
                    if (j == 0)
                    {
                        dgv[i-k, numRow - 1].Style.BackColor = Color.Green;
                        MessageBox.Show("Well done!!!");
                        return;
                    }
                    k++;

                }
            }
            MessageBox.Show("No found!!!");


        }
        private void getLib(string str, List<char> libSumbol, List<int> libNum)
        {
            for (int i = str.Length - 2; i > -1; i--)
            {
                bool flag = false;
                foreach (var item in libSumbol)
                {
                    if (str[i] == item)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                    continue;

                libSumbol.Add(str[i]);
                libNum.Add(str.Length - i - 1);
            }
            {
                bool flag = false;
                foreach (var item in libSumbol)
                {
                    if (str[str.Length - 1] == item)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    libSumbol.Add(str[str.Length - 1]);
                    libNum.Add(str.Length);
                }
                libSumbol.Add('*');
                libNum.Add(str.Length);

            }
               
        }
        private void btn_ClearTextBasic_Click(object sender, EventArgs e)
        {
            rtb_sample.Clear();
        }

        private void rtb_Basic_TextChanged(object sender, EventArgs e)
        {

        }
        private bool startAlgoritm(ref string  basic, ref string  sample)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            try
            {
                basic = rtb_Basic.Text;
                sample = rtb_sample.Text;
            }
            catch
            {
                MessageBox.Show("Ошибка преобразования текста");
                return false;
            }
            if (basic.Length == 0)
            {
                MessageBox.Show("Текст не обнаружен");
                return false;
            }
            if (sample.Length == 0)
            {
                MessageBox.Show("Образ не обнаружен");
                return false;
            }
            for (int a = 0; a < basic.Length; a++)
            {
                dgv.Columns.Add("DGV1", Convert.ToString(basic[a]));
                dgv.Columns[a].Width = dgv.Width / 20;
            }
            return true;
        }
    }
}
       
