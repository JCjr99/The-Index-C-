namespace Note_App
{
    partial class TheIndex
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.desTxt = new System.Windows.Forms.TextBox();
            this.solTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.solutionList = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.solutionMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.solutionList)).BeginInit();
            this.solutionMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Solution";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(79, 12);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(294, 20);
            this.titleTxt.TabIndex = 3;
            // 
            // desTxt
            // 
            this.desTxt.Location = new System.Drawing.Point(79, 38);
            this.desTxt.Multiline = true;
            this.desTxt.Name = "desTxt";
            this.desTxt.Size = new System.Drawing.Size(396, 128);
            this.desTxt.TabIndex = 4;
            // 
            // solTxt
            // 
            this.solTxt.Location = new System.Drawing.Point(79, 172);
            this.solTxt.Multiline = true;
            this.solTxt.Name = "solTxt";
            this.solTxt.Size = new System.Drawing.Size(396, 229);
            this.solTxt.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveBtn.Location = new System.Drawing.Point(160, 407);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(79, 407);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(75, 23);
            this.newBtn.TabIndex = 8;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(667, 407);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // solutionList
            // 
            this.solutionList.AllowUserToAddRows = false;
            this.solutionList.AllowUserToDeleteRows = false;
            this.solutionList.AllowUserToResizeColumns = false;
            this.solutionList.AllowUserToResizeRows = false;
            this.solutionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.solutionList.Location = new System.Drawing.Point(502, 15);
            this.solutionList.Name = "solutionList";
            this.solutionList.ReadOnly = true;
            this.solutionList.RowHeadersVisible = false;
            this.solutionList.Size = new System.Drawing.Size(240, 386);
            this.solutionList.TabIndex = 6;
            this.solutionList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.solutionList_CellClick);
            this.solutionList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.solutionList_MouseDown);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(502, 406);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // solutionMenuStrip
            // 
            this.solutionMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.solutionMenuStrip.Name = "solutionMenuStrip";
            this.solutionMenuStrip.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // TheIndex
            // 
            this.ClientSize = new System.Drawing.Size(754, 479);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.solutionList);
            this.Controls.Add(this.solTxt);
            this.Controls.Add(this.desTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "TheIndex";
            this.Text = "The Index";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.solutionList)).EndInit();
            this.solutionMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox desTxt;
        private System.Windows.Forms.TextBox solTxt;
        private System.Windows.Forms.DataGridView solutionList;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ContextMenuStrip solutionMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}

