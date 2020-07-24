namespace New_midtrem
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShop1Price = new System.Windows.Forms.Label();
            this.lblShop1Name = new System.Windows.Forms.Label();
            this.pbxSHOP1 = new System.Windows.Forms.PictureBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSHOP1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton2.Text = "toolStripButton1";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(428, 40);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(87, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "名稱:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(87, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "價格:";
            // 
            // lblShop1Price
            // 
            this.lblShop1Price.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShop1Price.Location = new System.Drawing.Point(144, 99);
            this.lblShop1Price.Name = "lblShop1Price";
            this.lblShop1Price.Size = new System.Drawing.Size(70, 23);
            this.lblShop1Price.TabIndex = 24;
            this.lblShop1Price.Text = "label2";
            // 
            // lblShop1Name
            // 
            this.lblShop1Name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShop1Name.Location = new System.Drawing.Point(144, 43);
            this.lblShop1Name.Name = "lblShop1Name";
            this.lblShop1Name.Size = new System.Drawing.Size(70, 23);
            this.lblShop1Name.TabIndex = 22;
            this.lblShop1Name.Text = "label1";
            // 
            // pbxSHOP1
            // 
            this.pbxSHOP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxSHOP1.Location = new System.Drawing.Point(12, 43);
            this.pbxSHOP1.Name = "pbxSHOP1";
            this.pbxSHOP1.Size = new System.Drawing.Size(69, 79);
            this.pbxSHOP1.TabIndex = 20;
            this.pbxSHOP1.TabStop = false;
            this.pbxSHOP1.Click += new System.EventHandler(this.pbxSHOP1_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(325, 145);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(87, 42);
            this.btnCheckOut.TabIndex = 23;
            this.btnCheckOut.Text = "結帳";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(235, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 79);
            this.listBox1.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(12, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 100);
            this.panel1.TabIndex = 27;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 318);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShop1Price);
            this.Controls.Add(this.lblShop1Name);
            this.Controls.Add(this.pbxSHOP1);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shop";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSHOP1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShop1Price;
        private System.Windows.Forms.Label lblShop1Name;
        private System.Windows.Forms.PictureBox pbxSHOP1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
    }
}