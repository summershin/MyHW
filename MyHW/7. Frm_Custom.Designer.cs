
namespace MyHW
{
    partial class Frm_Custom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Custom));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LargeIconList = new System.Windows.Forms.ImageList(this.components);
            this.SmallIconList = new System.Windows.Forms.ImageList(this.components);
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(220, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country: ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(322, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "請選擇國家";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.LargeIconList;
            this.listView1.Location = new System.Drawing.Point(45, 117);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(962, 428);
            this.listView1.SmallImageList = this.SmallIconList;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.detialsToolStripMenuItem,
            this.groupByToolStripMenuItem,
            this.orderByToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 124);
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.largeIconToolStripMenuItem.Text = "Large Icon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.smallIconToolStripMenuItem.Text = "Small Icon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // detialsToolStripMenuItem
            // 
            this.detialsToolStripMenuItem.Name = "detialsToolStripMenuItem";
            this.detialsToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.detialsToolStripMenuItem.Text = "Detials";
            this.detialsToolStripMenuItem.Click += new System.EventHandler(this.detialsToolStripMenuItem_Click);
            // 
            // groupByToolStripMenuItem
            // 
            this.groupByToolStripMenuItem.Name = "groupByToolStripMenuItem";
            this.groupByToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.groupByToolStripMenuItem.Text = "Group by";
            // 
            // orderByToolStripMenuItem
            // 
            this.orderByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cityToolStripMenuItem,
            this.countryToolStripMenuItem,
            this.companyNameToolStripMenuItem});
            this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
            this.orderByToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.orderByToolStripMenuItem.Text = "Order by";
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.cityToolStripMenuItem.Text = "City";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.cityToolStripMenuItem_Click);
            // 
            // LargeIconList
            // 
            this.LargeIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargeIconList.ImageStream")));
            this.LargeIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.LargeIconList.Images.SetKeyName(0, "Flag_of_Argentina.svg.png");
            this.LargeIconList.Images.SetKeyName(1, "Flag_of_Austria.svg.png");
            this.LargeIconList.Images.SetKeyName(2, "Flag_of_Belgium.svg.png");
            this.LargeIconList.Images.SetKeyName(3, "Flag_of_Brazil.svg.png");
            this.LargeIconList.Images.SetKeyName(4, "Flag_of_Canada_(3-2).svg.png");
            this.LargeIconList.Images.SetKeyName(5, "Flag_of_Denmark.svg.png");
            this.LargeIconList.Images.SetKeyName(6, "Flag_of_Finland.svg.png");
            this.LargeIconList.Images.SetKeyName(7, "Flag_of_France_(lighter_variant).svg.png");
            this.LargeIconList.Images.SetKeyName(8, "Flag_of_Germany.svg.png");
            this.LargeIconList.Images.SetKeyName(9, "Flag_of_Ireland.svg.png");
            this.LargeIconList.Images.SetKeyName(10, "Flag_of_Italy.svg.png");
            this.LargeIconList.Images.SetKeyName(11, "Flag_of_Mexico.png");
            this.LargeIconList.Images.SetKeyName(12, "Flag_of_Norway.svg.png");
            this.LargeIconList.Images.SetKeyName(13, "Flag_of_Poland.svg.png");
            this.LargeIconList.Images.SetKeyName(14, "Flag_of_Portugal.svg.png");
            this.LargeIconList.Images.SetKeyName(15, "Flag_of_Spain.svg.png");
            this.LargeIconList.Images.SetKeyName(16, "Flag_of_Sweden.svg.png");
            this.LargeIconList.Images.SetKeyName(17, "Flag_of_Switzerland.svg.png");
            this.LargeIconList.Images.SetKeyName(18, "Flag_of_the_United_Kingdom_Square.svg.png");
            this.LargeIconList.Images.SetKeyName(19, "Flag_of_the_United_States_(Pantone).svg.png");
            this.LargeIconList.Images.SetKeyName(20, "Flag_of_Venezuela_(state).svg.png");
            // 
            // SmallIconList
            // 
            this.SmallIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallIconList.ImageStream")));
            this.SmallIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.SmallIconList.Images.SetKeyName(0, "Flag_of_Argentina.svg.png");
            this.SmallIconList.Images.SetKeyName(1, "Flag_of_Austria.svg.png");
            this.SmallIconList.Images.SetKeyName(2, "Flag_of_Belgium.svg.png");
            this.SmallIconList.Images.SetKeyName(3, "Flag_of_Brazil.svg.png");
            this.SmallIconList.Images.SetKeyName(4, "Flag_of_Canada_(3-2).svg.png");
            this.SmallIconList.Images.SetKeyName(5, "Flag_of_Denmark.svg.png");
            this.SmallIconList.Images.SetKeyName(6, "Flag_of_Finland.svg.png");
            this.SmallIconList.Images.SetKeyName(7, "Flag_of_France_(lighter_variant).svg.png");
            this.SmallIconList.Images.SetKeyName(8, "Flag_of_Germany.svg.png");
            this.SmallIconList.Images.SetKeyName(9, "Flag_of_Ireland.svg.png");
            this.SmallIconList.Images.SetKeyName(10, "Flag_of_Italy.svg.png");
            this.SmallIconList.Images.SetKeyName(11, "Flag_of_Mexico.png");
            this.SmallIconList.Images.SetKeyName(12, "Flag_of_Norway.svg.png");
            this.SmallIconList.Images.SetKeyName(13, "Flag_of_Poland.svg.png");
            this.SmallIconList.Images.SetKeyName(14, "Flag_of_Portugal.svg.png");
            this.SmallIconList.Images.SetKeyName(15, "Flag_of_Spain.svg.png");
            this.SmallIconList.Images.SetKeyName(16, "Flag_of_Sweden.svg.png");
            this.SmallIconList.Images.SetKeyName(17, "Flag_of_Switzerland.svg.png");
            this.SmallIconList.Images.SetKeyName(18, "Flag_of_the_United_Kingdom_Square.svg.png");
            this.SmallIconList.Images.SetKeyName(19, "Flag_of_the_United_States_(Pantone).svg.png");
            this.SmallIconList.Images.SetKeyName(20, "Flag_of_Venezuela_(state).svg.png");
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.countryToolStripMenuItem.Text = "Country";
            this.countryToolStripMenuItem.Click += new System.EventHandler(this.countryToolStripMenuItem_Click);
            // 
            // companyNameToolStripMenuItem
            // 
            this.companyNameToolStripMenuItem.Name = "companyNameToolStripMenuItem";
            this.companyNameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.companyNameToolStripMenuItem.Text = "Company Name";
            this.companyNameToolStripMenuItem.Click += new System.EventHandler(this.companyNameToolStripMenuItem_Click);
            // 
            // Frm_Custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 628);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Custom";
            this.Text = "Frm_Custom";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
        private System.Windows.Forms.ImageList SmallIconList;
        private System.Windows.Forms.ImageList LargeIconList;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyNameToolStripMenuItem;
    }
}