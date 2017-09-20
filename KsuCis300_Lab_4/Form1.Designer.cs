namespace KsuCis300_Lab_4
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
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxWithString = new System.Windows.Forms.ToolStripMenuItem();
            this.uxWithStringBuilder = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.encryptToolStripMenuItem});
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(862, 42);
            this.uxMenuStrip.TabIndex = 0;
            this.uxMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenToolStripMenuItem,
            this.uxSaveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uxOpenToolStripMenuItem
            // 
            this.uxOpenToolStripMenuItem.Name = "uxOpenToolStripMenuItem";
            this.uxOpenToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.uxOpenToolStripMenuItem.Text = "Open...";
            this.uxOpenToolStripMenuItem.Click += new System.EventHandler(this.uxOpenToolStripMenuItem_Click);
            // 
            // uxSaveAsToolStripMenuItem
            // 
            this.uxSaveAsToolStripMenuItem.Name = "uxSaveAsToolStripMenuItem";
            this.uxSaveAsToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.uxSaveAsToolStripMenuItem.Text = "Save As...";
            this.uxSaveAsToolStripMenuItem.Click += new System.EventHandler(this.uxSaveAsToolStripMenuItem_Click);
            // 
            // uxTextBox
            // 
            this.uxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBox.Location = new System.Drawing.Point(31, 76);
            this.uxTextBox.Multiline = true;
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxTextBox.Size = new System.Drawing.Size(780, 404);
            this.uxTextBox.TabIndex = 1;
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.FileName = "openFileDialog1";
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxWithString,
            this.uxWithStringBuilder});
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(106, 38);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            // 
            // uxWithString
            // 
            this.uxWithString.Name = "uxWithString";
            this.uxWithString.Size = new System.Drawing.Size(323, 38);
            this.uxWithString.Text = "With String...";
            this.uxWithString.Click += new System.EventHandler(this.uxWithString_Click);
            // 
            // uxWithStringBuilder
            // 
            this.uxWithStringBuilder.Name = "uxWithStringBuilder";
            this.uxWithStringBuilder.Size = new System.Drawing.Size(323, 38);
            this.uxWithStringBuilder.Text = "With StringBuilder...";
            this.uxWithStringBuilder.Click += new System.EventHandler(this.uxWithStringBuilder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 509);
            this.Controls.Add(this.uxTextBox);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxSaveAsToolStripMenuItem;
        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxWithString;
        private System.Windows.Forms.ToolStripMenuItem uxWithStringBuilder;
    }
}

