
namespace Serch_String
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_Basic = new System.Windows.Forms.RichTextBox();
            this.rtb_sample = new System.Windows.Forms.RichTextBox();
            this.btn_ClearTextSample = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_GenText = new System.Windows.Forms.Button();
            this.btn_ClearTextBasic = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_BM = new System.Windows.Forms.Button();
            this.btn_KMP = new System.Windows.Forms.Button();
            this.btn_straight = new System.Windows.Forms.Button();
            this.label_Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_Basic
            // 
            this.rtb_Basic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Basic.BackColor = System.Drawing.Color.RoyalBlue;
            this.rtb_Basic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Basic.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_Basic.Location = new System.Drawing.Point(17, 64);
            this.rtb_Basic.Margin = new System.Windows.Forms.Padding(5);
            this.rtb_Basic.Name = "rtb_Basic";
            this.rtb_Basic.Size = new System.Drawing.Size(1345, 230);
            this.rtb_Basic.TabIndex = 0;
            this.rtb_Basic.Text = "";
            this.rtb_Basic.TextChanged += new System.EventHandler(this.rtb_Basic_TextChanged);
            // 
            // rtb_sample
            // 
            this.rtb_sample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_sample.BackColor = System.Drawing.Color.RoyalBlue;
            this.rtb_sample.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_sample.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_sample.Location = new System.Drawing.Point(21, 359);
            this.rtb_sample.Margin = new System.Windows.Forms.Padding(5);
            this.rtb_sample.Name = "rtb_sample";
            this.rtb_sample.Size = new System.Drawing.Size(997, 96);
            this.rtb_sample.TabIndex = 1;
            this.rtb_sample.Text = "";
            // 
            // btn_ClearTextSample
            // 
            this.btn_ClearTextSample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearTextSample.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ClearTextSample.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ClearTextSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearTextSample.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ClearTextSample.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ClearTextSample.Location = new System.Drawing.Point(0, 0);
            this.btn_ClearTextSample.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ClearTextSample.Name = "btn_ClearTextSample";
            this.btn_ClearTextSample.Size = new System.Drawing.Size(113, 96);
            this.btn_ClearTextSample.TabIndex = 3;
            this.btn_ClearTextSample.Text = "Очистить";
            this.btn_ClearTextSample.UseVisualStyleBackColor = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(333, 529);
            this.dgv.Margin = new System.Windows.Forms.Padding(5);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(1033, 346);
            this.dgv.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_GenText);
            this.panel1.Controls.Add(this.btn_ClearTextBasic);
            this.panel1.Controls.Add(this.btn_ClearTextSample);
            this.panel1.Location = new System.Drawing.Point(1029, 359);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 96);
            this.panel1.TabIndex = 8;
            // 
            // btn_GenText
            // 
            this.btn_GenText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GenText.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_GenText.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_GenText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GenText.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_GenText.ForeColor = System.Drawing.Color.Lime;
            this.btn_GenText.Location = new System.Drawing.Point(224, 0);
            this.btn_GenText.Margin = new System.Windows.Forms.Padding(5);
            this.btn_GenText.Name = "btn_GenText";
            this.btn_GenText.Size = new System.Drawing.Size(113, 96);
            this.btn_GenText.TabIndex = 5;
            this.btn_GenText.Text = "Генерация текста";
            this.btn_GenText.UseVisualStyleBackColor = false;
            this.btn_GenText.Click += new System.EventHandler(this.btn_GenText_Click);
            // 
            // btn_ClearTextBasic
            // 
            this.btn_ClearTextBasic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearTextBasic.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ClearTextBasic.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ClearTextBasic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearTextBasic.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ClearTextBasic.ForeColor = System.Drawing.Color.MintCream;
            this.btn_ClearTextBasic.Location = new System.Drawing.Point(112, 0);
            this.btn_ClearTextBasic.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ClearTextBasic.Name = "btn_ClearTextBasic";
            this.btn_ClearTextBasic.Size = new System.Drawing.Size(113, 96);
            this.btn_ClearTextBasic.TabIndex = 4;
            this.btn_ClearTextBasic.Text = "Очистить";
            this.btn_ClearTextBasic.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_BM);
            this.panel2.Controls.Add(this.btn_KMP);
            this.panel2.Controls.Add(this.btn_straight);
            this.panel2.Location = new System.Drawing.Point(21, 497);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 361);
            this.panel2.TabIndex = 9;
            // 
            // btn_BM
            // 
            this.btn_BM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BM.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_BM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_BM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BM.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_BM.Location = new System.Drawing.Point(-4, 260);
            this.btn_BM.Margin = new System.Windows.Forms.Padding(5);
            this.btn_BM.Name = "btn_BM";
            this.btn_BM.Size = new System.Drawing.Size(279, 96);
            this.btn_BM.TabIndex = 10;
            this.btn_BM.Text = "Боуера и Мура.";
            this.btn_BM.UseVisualStyleBackColor = false;
            this.btn_BM.Click += new System.EventHandler(this.btn_BM_Click);
            // 
            // btn_KMP
            // 
            this.btn_KMP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_KMP.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_KMP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_KMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KMP.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KMP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_KMP.Location = new System.Drawing.Point(0, 129);
            this.btn_KMP.Margin = new System.Windows.Forms.Padding(5);
            this.btn_KMP.Name = "btn_KMP";
            this.btn_KMP.Size = new System.Drawing.Size(275, 96);
            this.btn_KMP.TabIndex = 9;
            this.btn_KMP.Text = "Кнута, Морриса и Пратта";
            this.btn_KMP.UseVisualStyleBackColor = false;
            this.btn_KMP.Click += new System.EventHandler(this.btn_KMP_Click);
            // 
            // btn_straight
            // 
            this.btn_straight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_straight.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_straight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_straight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_straight.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_straight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_straight.Location = new System.Drawing.Point(0, 5);
            this.btn_straight.Margin = new System.Windows.Forms.Padding(5);
            this.btn_straight.Name = "btn_straight";
            this.btn_straight.Size = new System.Drawing.Size(275, 96);
            this.btn_straight.TabIndex = 8;
            this.btn_straight.Text = "Прямой метод";
            this.btn_straight.UseVisualStyleBackColor = false;
            this.btn_straight.Click += new System.EventHandler(this.btn_straight_Click);
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.BackColor = System.Drawing.Color.Transparent;
            this.label_Time.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Time.ForeColor = System.Drawing.Color.MintCream;
            this.label_Time.Location = new System.Drawing.Point(325, 482);
            this.label_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(128, 42);
            this.label_Time.TabIndex = 12;
            this.label_Time.Text = "Время:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(9, 314);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите слово:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "Введите текст:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Serch_String.Properties.Resources._1616610153_47_p_sinii_fon_kosmos_53;
            this.ClientSize = new System.Drawing.Size(1397, 884);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.rtb_sample);
            this.Controls.Add(this.rtb_Basic);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Basic;
        private System.Windows.Forms.RichTextBox rtb_sample;
        private System.Windows.Forms.Button btn_ClearTextSample;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_GenText;
        private System.Windows.Forms.Button btn_ClearTextBasic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_BM;
        private System.Windows.Forms.Button btn_KMP;
        private System.Windows.Forms.Button btn_straight;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

