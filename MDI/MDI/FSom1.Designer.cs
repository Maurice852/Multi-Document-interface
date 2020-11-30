namespace MDI
{
    partial class FSom1
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
            this.fillRandom = new System.Windows.Forms.Button();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.sumSelec = new System.Windows.Forms.Button();
            this.selecToRight = new System.Windows.Forms.Button();
            this.allToRight = new System.Windows.Forms.Button();
            this.delSelec = new System.Windows.Forms.Button();
            this.allToLeft = new System.Windows.Forms.Button();
            this.selecToLeft = new System.Windows.Forms.Button();
            this.ListLeft = new System.Windows.Forms.ListBox();
            this.ListRight = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // fillRandom
            // 
            this.fillRandom.Location = new System.Drawing.Point(13, 13);
            this.fillRandom.Name = "fillRandom";
            this.fillRandom.Size = new System.Drawing.Size(121, 23);
            this.fillRandom.TabIndex = 0;
            this.fillRandom.Text = "Fill random";
            this.fillRandom.UseVisualStyleBackColor = true;
            this.fillRandom.Click += new System.EventHandler(this.fillRandom_Click);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(167, 13);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 22);
            this.txtSum.TabIndex = 2;
            // 
            // sumSelec
            // 
            this.sumSelec.Location = new System.Drawing.Point(155, 68);
            this.sumSelec.Name = "sumSelec";
            this.sumSelec.Size = new System.Drawing.Size(121, 23);
            this.sumSelec.TabIndex = 5;
            this.sumSelec.Text = "Sum selected";
            this.sumSelec.UseVisualStyleBackColor = true;
            this.sumSelec.Click += new System.EventHandler(this.sumSelec_Click);
            // 
            // selecToRight
            // 
            this.selecToRight.Location = new System.Drawing.Point(155, 157);
            this.selecToRight.Name = "selecToRight";
            this.selecToRight.Size = new System.Drawing.Size(121, 23);
            this.selecToRight.TabIndex = 6;
            this.selecToRight.Text = ">";
            this.selecToRight.UseVisualStyleBackColor = true;
            this.selecToRight.Click += new System.EventHandler(this.selecToRight_Click);
            // 
            // allToRight
            // 
            this.allToRight.Location = new System.Drawing.Point(155, 186);
            this.allToRight.Name = "allToRight";
            this.allToRight.Size = new System.Drawing.Size(121, 23);
            this.allToRight.TabIndex = 7;
            this.allToRight.Text = ">>";
            this.allToRight.UseVisualStyleBackColor = true;
            this.allToRight.Click += new System.EventHandler(this.allToRight_Click);
            // 
            // delSelec
            // 
            this.delSelec.Location = new System.Drawing.Point(155, 128);
            this.delSelec.Name = "delSelec";
            this.delSelec.Size = new System.Drawing.Size(121, 23);
            this.delSelec.TabIndex = 8;
            this.delSelec.Text = "Del selected";
            this.delSelec.UseVisualStyleBackColor = true;
            this.delSelec.Click += new System.EventHandler(this.delSelec_Click);
            // 
            // allToLeft
            // 
            this.allToLeft.Location = new System.Drawing.Point(155, 215);
            this.allToLeft.Name = "allToLeft";
            this.allToLeft.Size = new System.Drawing.Size(121, 23);
            this.allToLeft.TabIndex = 9;
            this.allToLeft.Text = "<<";
            this.allToLeft.UseVisualStyleBackColor = true;
            this.allToLeft.Click += new System.EventHandler(this.allToLeft_Click);
            // 
            // selecToLeft
            // 
            this.selecToLeft.Location = new System.Drawing.Point(155, 244);
            this.selecToLeft.Name = "selecToLeft";
            this.selecToLeft.Size = new System.Drawing.Size(121, 23);
            this.selecToLeft.TabIndex = 10;
            this.selecToLeft.Text = "<";
            this.selecToLeft.UseVisualStyleBackColor = true;
            this.selecToLeft.Click += new System.EventHandler(this.selecToLeft_Click);
            // 
            // ListLeft
            // 
            this.ListLeft.FormattingEnabled = true;
            this.ListLeft.ItemHeight = 16;
            this.ListLeft.Location = new System.Drawing.Point(14, 68);
            this.ListLeft.Name = "ListLeft";
            this.ListLeft.Size = new System.Drawing.Size(120, 196);
            this.ListLeft.TabIndex = 12;
            // 
            // ListRight
            // 
            this.ListRight.FormattingEnabled = true;
            this.ListRight.ItemHeight = 16;
            this.ListRight.Location = new System.Drawing.Point(297, 68);
            this.ListRight.Name = "ListRight";
            this.ListRight.Size = new System.Drawing.Size(120, 196);
            this.ListRight.TabIndex = 13;
            // 
            // FSom1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 334);
            this.Controls.Add(this.ListRight);
            this.Controls.Add(this.ListLeft);
            this.Controls.Add(this.selecToLeft);
            this.Controls.Add(this.allToLeft);
            this.Controls.Add(this.delSelec);
            this.Controls.Add(this.allToRight);
            this.Controls.Add(this.selecToRight);
            this.Controls.Add(this.sumSelec);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.fillRandom);
            this.Name = "FSom1";
            this.Text = "FSom1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FSom1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selecToLeft;
        private System.Windows.Forms.Button allToLeft;
        private System.Windows.Forms.Button delSelec;
        private System.Windows.Forms.Button allToRight;
        private System.Windows.Forms.Button selecToRight;
        private System.Windows.Forms.Button sumSelec;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button fillRandom;
        private System.Windows.Forms.ListBox ListLeft;
        private System.Windows.Forms.ListBox ListRight;
    }
}