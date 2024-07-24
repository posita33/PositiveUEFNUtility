namespace PositiveUEFNUtility
{
    partial class WinCSVToVerseStructure
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
            this.textBoxConvertText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVariables = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDiscord = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxConvertText
            // 
            this.textBoxConvertText.AllowDrop = true;
            this.textBoxConvertText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConvertText.Location = new System.Drawing.Point(12, 90);
            this.textBoxConvertText.MaxLength = 10000000;
            this.textBoxConvertText.Multiline = true;
            this.textBoxConvertText.Name = "textBoxConvertText";
            this.textBoxConvertText.Size = new System.Drawing.Size(776, 348);
            this.textBoxConvertText.TabIndex = 4;
            this.textBoxConvertText.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxConvertText_DragDrop);
            this.textBoxConvertText.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxConvertText_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "CSVファイルをドラッグ＆ドロップ";
            // 
            // textBoxVariables
            // 
            this.textBoxVariables.Location = new System.Drawing.Point(60, 40);
            this.textBoxVariables.Name = "textBoxVariables";
            this.textBoxVariables.Size = new System.Drawing.Size(201, 19);
            this.textBoxVariables.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "変数名";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDocument,
            this.ToolStripMenuItemDiscord});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ToolStripMenuItemDocument
            // 
            this.ToolStripMenuItemDocument.Name = "ToolStripMenuItemDocument";
            this.ToolStripMenuItemDocument.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemDocument.Text = "使い方";
            this.ToolStripMenuItemDocument.Click += new System.EventHandler(this.ToolStripMenuItemDocument_Click);
            // 
            // ToolStripMenuItemDiscord
            // 
            this.ToolStripMenuItemDiscord.Name = "ToolStripMenuItemDiscord";
            this.ToolStripMenuItemDiscord.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemDiscord.Text = "Discord";
            this.ToolStripMenuItemDiscord.Click += new System.EventHandler(this.ToolStripMenuItemDiscord_Click);
            // 
            // WinCSVToVerseStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVariables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxConvertText);
            this.Name = "WinCSVToVerseStructure";
            this.Text = "WinCSVToVerseStructure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinCSVToVerseStructure_FormClosing);
            this.Load += new System.EventHandler(this.WinCSVToVerseStructure_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConvertText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVariables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDocument;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDiscord;
    }
}