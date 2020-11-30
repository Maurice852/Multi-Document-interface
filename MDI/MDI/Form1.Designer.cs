namespace MDI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sommetjesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.som1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.som2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.som3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sommetjesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sommetjesToolStripMenuItem
            // 
            this.sommetjesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.som1ToolStripMenuItem,
            this.som2ToolStripMenuItem,
            this.som3ToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.sommetjesToolStripMenuItem.Name = "sommetjesToolStripMenuItem";
            this.sommetjesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.sommetjesToolStripMenuItem.Text = "Sommetjes";
            // 
            // som1ToolStripMenuItem
            // 
            this.som1ToolStripMenuItem.Name = "som1ToolStripMenuItem";
            this.som1ToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.som1ToolStripMenuItem.Text = "Som1";
            this.som1ToolStripMenuItem.Click += new System.EventHandler(this.som1ToolStripMenuItem_Click);
            // 
            // som2ToolStripMenuItem
            // 
            this.som2ToolStripMenuItem.Name = "som2ToolStripMenuItem";
            this.som2ToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.som2ToolStripMenuItem.Text = "Som2";
            this.som2ToolStripMenuItem.Click += new System.EventHandler(this.som2ToolStripMenuItem_Click);
            // 
            // som3ToolStripMenuItem
            // 
            this.som3ToolStripMenuItem.Name = "som3ToolStripMenuItem";
            this.som3ToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.som3ToolStripMenuItem.Text = "Som3";
            this.som3ToolStripMenuItem.Click += new System.EventHandler(this.som3ToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 415);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sommetjesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem som1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem som2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem som3ToolStripMenuItem;
    }
}

