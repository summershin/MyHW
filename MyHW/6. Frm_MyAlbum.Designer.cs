
namespace MyHW
{
    partial class Frm_MyAlbum
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myAlbumDataSet1 = new MyHW.MyAlbumDataSet();
            this.cityTableAdapter1 = new MyHW.MyAlbumDataSetTableAdapters.CityTableAdapter();
            this.photoTableAdapter1 = new MyHW.MyAlbumDataSetTableAdapters.PhotoTableAdapter();
            this.btn_ShowPhoto = new System.Windows.Forms.Button();
            this.btn_ShowCity = new System.Windows.Forms.Button();
            this.btn_SaveCity = new System.Windows.Forms.Button();
            this.btn_SavePhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(311, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Album";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 128);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(801, 322);
            this.splitContainer1.SplitterDistance = 135;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // myAlbumDataSet1
            // 
            this.myAlbumDataSet1.DataSetName = "MyAlbumDataSet";
            this.myAlbumDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityTableAdapter1
            // 
            this.cityTableAdapter1.ClearBeforeFill = true;
            // 
            // photoTableAdapter1
            // 
            this.photoTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_ShowPhoto
            // 
            this.btn_ShowPhoto.Location = new System.Drawing.Point(599, 64);
            this.btn_ShowPhoto.Name = "btn_ShowPhoto";
            this.btn_ShowPhoto.Size = new System.Drawing.Size(99, 26);
            this.btn_ShowPhoto.TabIndex = 2;
            this.btn_ShowPhoto.Text = "Show Photo";
            this.btn_ShowPhoto.UseVisualStyleBackColor = true;
            this.btn_ShowPhoto.Click += new System.EventHandler(this.btn_ShowPhoto_Click);
            // 
            // btn_ShowCity
            // 
            this.btn_ShowCity.Location = new System.Drawing.Point(707, 64);
            this.btn_ShowCity.Name = "btn_ShowCity";
            this.btn_ShowCity.Size = new System.Drawing.Size(81, 26);
            this.btn_ShowCity.TabIndex = 3;
            this.btn_ShowCity.Text = "Show City";
            this.btn_ShowCity.UseVisualStyleBackColor = true;
            this.btn_ShowCity.Click += new System.EventHandler(this.btn_ShowCity_Click);
            // 
            // btn_SaveCity
            // 
            this.btn_SaveCity.Location = new System.Drawing.Point(707, 96);
            this.btn_SaveCity.Name = "btn_SaveCity";
            this.btn_SaveCity.Size = new System.Drawing.Size(81, 26);
            this.btn_SaveCity.TabIndex = 5;
            this.btn_SaveCity.Text = "Save City";
            this.btn_SaveCity.UseVisualStyleBackColor = true;
            this.btn_SaveCity.Click += new System.EventHandler(this.btn_SaveCity_Click);
            // 
            // btn_SavePhoto
            // 
            this.btn_SavePhoto.Location = new System.Drawing.Point(599, 96);
            this.btn_SavePhoto.Name = "btn_SavePhoto";
            this.btn_SavePhoto.Size = new System.Drawing.Size(99, 26);
            this.btn_SavePhoto.TabIndex = 4;
            this.btn_SavePhoto.Text = "Save Photo";
            this.btn_SavePhoto.UseVisualStyleBackColor = true;
            this.btn_SavePhoto.Click += new System.EventHandler(this.btn_SavePhoto_Click);
            // 
            // Frm_MyAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SaveCity);
            this.Controls.Add(this.btn_SavePhoto);
            this.Controls.Add(this.btn_ShowCity);
            this.Controls.Add(this.btn_ShowPhoto);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_MyAlbum";
            this.Text = "Frm_MyAlbum";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyAlbumDataSet myAlbumDataSet1;
        private MyAlbumDataSetTableAdapters.CityTableAdapter cityTableAdapter1;
        private MyAlbumDataSetTableAdapters.PhotoTableAdapter photoTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ShowPhoto;
        private System.Windows.Forms.Button btn_ShowCity;
        private System.Windows.Forms.Button btn_SaveCity;
        private System.Windows.Forms.Button btn_SavePhoto;
    }
}