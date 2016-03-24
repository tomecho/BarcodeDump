namespace BarcodeDump
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItemEXPORT = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItemEXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.activeDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXPERIMENTALOrganizationalUnitMoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBox1.Location = new System.Drawing.Point(15, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(299, 256);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Export to Text File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.activeDirectoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItemEXPORT,
            this.exitToolStripMenuItemEXIT});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItemEXPORT
            // 
            this.exitToolStripMenuItemEXPORT.Name = "exitToolStripMenuItemEXPORT";
            this.exitToolStripMenuItemEXPORT.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItemEXPORT.Text = "Export";
            this.exitToolStripMenuItemEXPORT.Click += new System.EventHandler(this.exitToolStripMenuItemEXPORT_Click);
            // 
            // exitToolStripMenuItemEXIT
            // 
            this.exitToolStripMenuItemEXIT.Name = "exitToolStripMenuItemEXIT";
            this.exitToolStripMenuItemEXIT.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItemEXIT.Text = "Exit";
            this.exitToolStripMenuItemEXIT.Click += new System.EventHandler(this.exitToolStripMenuItemEXIT_Click);
            // 
            // activeDirectoryToolStripMenuItem
            // 
            this.activeDirectoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXPERIMENTALOrganizationalUnitMoverToolStripMenuItem});
            this.activeDirectoryToolStripMenuItem.Name = "activeDirectoryToolStripMenuItem";
            this.activeDirectoryToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.activeDirectoryToolStripMenuItem.Text = "Active Directory";
            // 
            // eXPERIMENTALOrganizationalUnitMoverToolStripMenuItem
            // 
            this.eXPERIMENTALOrganizationalUnitMoverToolStripMenuItem.Name = "eXPERIMENTALOrganizationalUnitMoverToolStripMenuItem";
            this.eXPERIMENTALOrganizationalUnitMoverToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.eXPERIMENTALOrganizationalUnitMoverToolStripMenuItem.Text = "EXPERIMENTAL organizational unit mover";
            this.eXPERIMENTALOrganizationalUnitMoverToolStripMenuItem.Click += new System.EventHandler(this.eXPERIMENTALOrganizationalUnitMoverToolStripMenuItem_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(104, 17);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Barcode Length:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Barcode Reader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItemEXPORT;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItemEXIT;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem activeDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXPERIMENTALOrganizationalUnitMoverToolStripMenuItem;
    }
}

