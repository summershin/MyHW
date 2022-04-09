
namespace WindowsFormsApp1
{
    partial class FrmHomeWork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SixRan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_keyin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_binary = new System.Windows.Forms.Button();
            this.btn_Cc = new System.Windows.Forms.Button();
            this.btn_LongestName = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_do = new System.Windows.Forms.Button();
            this.btn_while = new System.Windows.Forms.Button();
            this.btn_for = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_step = new System.Windows.Forms.TextBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.btn_OddAndEven = new System.Windows.Forms.Button();
            this.btn_MaxAndMin = new System.Windows.Forms.Button();
            this.btn_params = new System.Windows.Forms.Button();
            this.btn_threenums = new System.Windows.Forms.Button();
            this.btn_OddOrEven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SixRan
            // 
            this.btn_SixRan.Location = new System.Drawing.Point(639, 159);
            this.btn_SixRan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SixRan.Name = "btn_SixRan";
            this.btn_SixRan.Size = new System.Drawing.Size(196, 37);
            this.btn_SixRan.TabIndex = 104;
            this.btn_SixRan.Text = "int[] 樂透 6個號碼不重複";
            this.btn_SixRan.UseVisualStyleBackColor = true;
            this.btn_SixRan.Click += new System.EventHandler(this.btn_SixRan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(33, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 33);
            this.label7.TabIndex = 101;
            this.label7.Text = "Result:";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(39, 314);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(105, 33);
            this.btn_clear.TabIndex = 100;
            this.btn_clear.Text = "清空結果欄";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("新細明體", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(86, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 34);
            this.label5.TabIndex = 99;
            // 
            // txt_keyin
            // 
            this.txt_keyin.Location = new System.Drawing.Point(92, 32);
            this.txt_keyin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_keyin.Name = "txt_keyin";
            this.txt_keyin.Size = new System.Drawing.Size(100, 25);
            this.txt_keyin.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 97;
            this.label6.Text = "Number:";
            // 
            // btn_binary
            // 
            this.btn_binary.Location = new System.Drawing.Point(523, 77);
            this.btn_binary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_binary.Name = "btn_binary";
            this.btn_binary.Size = new System.Drawing.Size(156, 28);
            this.btn_binary.TabIndex = 96;
            this.btn_binary.Text = "100 的 二進位是多少 ?";
            this.btn_binary.UseVisualStyleBackColor = true;
            this.btn_binary.Click += new System.EventHandler(this.btn_binary_Click);
            // 
            // btn_Cc
            // 
            this.btn_Cc.Location = new System.Drawing.Point(599, 220);
            this.btn_Cc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cc.Name = "btn_Cc";
            this.btn_Cc.Size = new System.Drawing.Size(296, 48);
            this.btn_Cc.TabIndex = 95;
            this.btn_Cc.Text = "string[] 名字有 “C” or “c” 字樣有幾個 ";
            this.btn_Cc.UseVisualStyleBackColor = true;
            this.btn_Cc.Click += new System.EventHandler(this.btn_Cc_Click);
            // 
            // btn_LongestName
            // 
            this.btn_LongestName.Location = new System.Drawing.Point(39, 236);
            this.btn_LongestName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LongestName.Name = "btn_LongestName";
            this.btn_LongestName.Size = new System.Drawing.Size(279, 35);
            this.btn_LongestName.TabIndex = 94;
            this.btn_LongestName.Text = "string[] 最長名字 ?";
            this.btn_LongestName.UseVisualStyleBackColor = true;
            this.btn_LongestName.Click += new System.EventHandler(this.btn_LongestName_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Black;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Consolas", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Lime;
            this.lblResult.Location = new System.Drawing.Point(150, 368);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(97, 42);
            this.lblResult.TabIndex = 93;
            this.lblResult.Text = "結果";
            // 
            // btn_nine
            // 
            this.btn_nine.Location = new System.Drawing.Point(523, 30);
            this.btn_nine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(156, 28);
            this.btn_nine.TabIndex = 92;
            this.btn_nine.Text = "九九乘法表";
            this.btn_nine.UseVisualStyleBackColor = true;
            this.btn_nine.Click += new System.EventHandler(this.btn_nine_Click);
            // 
            // btn_do
            // 
            this.btn_do.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_do.Location = new System.Drawing.Point(416, 127);
            this.btn_do.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(75, 22);
            this.btn_do.TabIndex = 91;
            this.btn_do.Text = "do";
            this.btn_do.UseVisualStyleBackColor = false;
            this.btn_do.Click += new System.EventHandler(this.btn_do_Click);
            // 
            // btn_while
            // 
            this.btn_while.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_while.Location = new System.Drawing.Point(416, 80);
            this.btn_while.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_while.Name = "btn_while";
            this.btn_while.Size = new System.Drawing.Size(75, 22);
            this.btn_while.TabIndex = 90;
            this.btn_while.Text = "while";
            this.btn_while.UseVisualStyleBackColor = false;
            this.btn_while.Click += new System.EventHandler(this.btn_while_Click);
            // 
            // btn_for
            // 
            this.btn_for.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_for.Location = new System.Drawing.Point(416, 32);
            this.btn_for.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(75, 22);
            this.btn_for.TabIndex = 89;
            this.btn_for.Text = "for";
            this.btn_for.UseVisualStyleBackColor = false;
            this.btn_for.Click += new System.EventHandler(this.btn_for_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(222, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 88;
            this.label3.Text = "Step:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(237, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 87;
            this.label2.Text = "to:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(226, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 86;
            this.label1.Text = "from:";
            // 
            // txt_step
            // 
            this.txt_step.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_step.Location = new System.Drawing.Point(281, 120);
            this.txt_step.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_step.Name = "txt_step";
            this.txt_step.Size = new System.Drawing.Size(100, 25);
            this.txt_step.TabIndex = 85;
            // 
            // txt_to
            // 
            this.txt_to.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_to.Location = new System.Drawing.Point(281, 72);
            this.txt_to.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(100, 25);
            this.txt_to.TabIndex = 84;
            // 
            // txt_from
            // 
            this.txt_from.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_from.Location = new System.Drawing.Point(281, 32);
            this.txt_from.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(100, 25);
            this.txt_from.TabIndex = 83;
            // 
            // btn_OddAndEven
            // 
            this.btn_OddAndEven.Location = new System.Drawing.Point(39, 183);
            this.btn_OddAndEven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OddAndEven.Name = "btn_OddAndEven";
            this.btn_OddAndEven.Size = new System.Drawing.Size(279, 35);
            this.btn_OddAndEven.TabIndex = 78;
            this.btn_OddAndEven.Text = "int[] 統計 奇數 有幾個 , 偶數有幾個";
            this.btn_OddAndEven.UseVisualStyleBackColor = true;
            this.btn_OddAndEven.Click += new System.EventHandler(this.btn_OddAndEven_Click);
            // 
            // btn_MaxAndMin
            // 
            this.btn_MaxAndMin.Location = new System.Drawing.Point(358, 233);
            this.btn_MaxAndMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_MaxAndMin.Name = "btn_MaxAndMin";
            this.btn_MaxAndMin.Size = new System.Drawing.Size(203, 35);
            this.btn_MaxAndMin.TabIndex = 77;
            this.btn_MaxAndMin.Text = " MAX()   / Min ( int[] )";
            this.btn_MaxAndMin.UseVisualStyleBackColor = true;
            this.btn_MaxAndMin.Click += new System.EventHandler(this.btn_MaxAndMin_Click);
            // 
            // btn_params
            // 
            this.btn_params.Location = new System.Drawing.Point(358, 173);
            this.btn_params.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_params.Name = "btn_params";
            this.btn_params.Size = new System.Drawing.Size(203, 35);
            this.btn_params.TabIndex = 76;
            this.btn_params.Text = "Max (params int[] )";
            this.btn_params.UseVisualStyleBackColor = true;
            this.btn_params.Click += new System.EventHandler(this.btn_params_Click);
            // 
            // btn_threenums
            // 
            this.btn_threenums.Location = new System.Drawing.Point(39, 123);
            this.btn_threenums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_threenums.Name = "btn_threenums";
            this.btn_threenums.Size = new System.Drawing.Size(155, 28);
            this.btn_threenums.TabIndex = 74;
            this.btn_threenums.Text = "3 個數的最大值";
            this.btn_threenums.UseVisualStyleBackColor = true;
            this.btn_threenums.Click += new System.EventHandler(this.btn_threenums_Click);
            // 
            // btn_OddOrEven
            // 
            this.btn_OddOrEven.Location = new System.Drawing.Point(39, 92);
            this.btn_OddOrEven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OddOrEven.Name = "btn_OddOrEven";
            this.btn_OddOrEven.Size = new System.Drawing.Size(155, 27);
            this.btn_OddOrEven.TabIndex = 73;
            this.btn_OddOrEven.Text = "Odd or Even";
            this.btn_OddOrEven.UseVisualStyleBackColor = true;
            this.btn_OddOrEven.Click += new System.EventHandler(this.btn_OddOrEven_Click);
            // 
            // FrmHomeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1037, 544);
            this.Controls.Add(this.btn_SixRan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_keyin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_binary);
            this.Controls.Add(this.btn_Cc);
            this.Controls.Add(this.btn_LongestName);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btn_nine);
            this.Controls.Add(this.btn_do);
            this.Controls.Add(this.btn_while);
            this.Controls.Add(this.btn_for);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_step);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.btn_OddAndEven);
            this.Controls.Add(this.btn_MaxAndMin);
            this.Controls.Add(this.btn_params);
            this.Controls.Add(this.btn_threenums);
            this.Controls.Add(this.btn_OddOrEven);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHomeWork";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SixRan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_keyin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_binary;
        private System.Windows.Forms.Button btn_Cc;
        private System.Windows.Forms.Button btn_LongestName;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_do;
        private System.Windows.Forms.Button btn_while;
        private System.Windows.Forms.Button btn_for;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_step;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.Button btn_OddAndEven;
        private System.Windows.Forms.Button btn_MaxAndMin;
        private System.Windows.Forms.Button btn_params;
        private System.Windows.Forms.Button btn_threenums;
        private System.Windows.Forms.Button btn_OddOrEven;
    }
}