
namespace MyHW
{
    partial class Frm_Logon
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.myMemberDS1 = new MyHW.MyMemberDS();
            this.memberTableAdapter1 = new MyHW.MyMemberDSTableAdapters.MemberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myMemberDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用者名稱: (U)";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(200, 66);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(218, 22);
            this.txt_UserName.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(200, 124);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(218, 22);
            this.txt_Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼: (P)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "確認(O)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 173);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消(C)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(439, 173);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "建立帳號";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // myMemberDS1
            // 
            this.myMemberDS1.DataSetName = "MyMemberDS";
            this.myMemberDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_Logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 286);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Logon";
            this.Text = "Frm_Logon";
            ((System.ComponentModel.ISupportInitialize)(this.myMemberDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private MyMemberDS myMemberDS1;
        private MyMemberDSTableAdapters.MemberTableAdapter memberTableAdapter1;
    }
}