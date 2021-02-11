namespace Note_App
{
    partial class SolutionInfo
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
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.desTxt = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.solTxt = new System.Windows.Forms.TextBox();
            this.solLbl = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            this.titleTxt.BackColor = System.Drawing.SystemColors.Menu;
            this.titleTxt.Location = new System.Drawing.Point(69, 12);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.ReadOnly = true;
            this.titleTxt.Size = new System.Drawing.Size(678, 20);
            this.titleTxt.TabIndex = 0;
            // 
            // desTxt
            // 
            this.desTxt.BackColor = System.Drawing.SystemColors.Menu;
            this.desTxt.Location = new System.Drawing.Point(69, 47);
            this.desTxt.Multiline = true;
            this.desTxt.Name = "desTxt";
            this.desTxt.ReadOnly = true;
            this.desTxt.Size = new System.Drawing.Size(710, 109);
            this.desTxt.TabIndex = 1;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(3, 12);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(27, 13);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description";
            // 
            // solTxt
            // 
            this.solTxt.BackColor = System.Drawing.SystemColors.Menu;
            this.solTxt.Location = new System.Drawing.Point(69, 173);
            this.solTxt.Multiline = true;
            this.solTxt.Name = "solTxt";
            this.solTxt.ReadOnly = true;
            this.solTxt.Size = new System.Drawing.Size(710, 202);
            this.solTxt.TabIndex = 4;
            // 
            // solLbl
            // 
            this.solLbl.AutoSize = true;
            this.solLbl.Location = new System.Drawing.Point(3, 173);
            this.solLbl.Name = "solLbl";
            this.solLbl.Size = new System.Drawing.Size(45, 13);
            this.solLbl.TabIndex = 5;
            this.solLbl.Text = "Solution";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(704, 381);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // SolutionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.solLbl);
            this.Controls.Add(this.solTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.desTxt);
            this.Controls.Add(this.titleTxt);
            this.Name = "SolutionInfo";
            this.Text = "SolutionInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox desTxt;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox solTxt;
        private System.Windows.Forms.Label solLbl;
        private System.Windows.Forms.Button okBtn;
    }
}