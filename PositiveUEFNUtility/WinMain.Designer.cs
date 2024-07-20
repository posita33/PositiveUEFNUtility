namespace PositiveUEFNUtility
{
    partial class WinMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOpenForumLeaning = new System.Windows.Forms.Button();
            this.buttonOpenOfficialDocument = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonShowWinConvertTextAlignDuplicate = new System.Windows.Forms.Button();
            this.buttonShowWinGetOutlinerActorLabel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDiscord = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonOpenForumLeaning);
            this.groupBox1.Controls.Add(this.buttonOpenOfficialDocument);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "URLボタン";
            // 
            // buttonOpenForumLeaning
            // 
            this.buttonOpenForumLeaning.Location = new System.Drawing.Point(120, 19);
            this.buttonOpenForumLeaning.Name = "buttonOpenForumLeaning";
            this.buttonOpenForumLeaning.Size = new System.Drawing.Size(107, 23);
            this.buttonOpenForumLeaning.TabIndex = 1;
            this.buttonOpenForumLeaning.Text = "Forum(ラーニング)";
            this.buttonOpenForumLeaning.UseVisualStyleBackColor = true;
            this.buttonOpenForumLeaning.Click += new System.EventHandler(this.buttonOpenForumLeaning_Click);
            // 
            // buttonOpenOfficialDocument
            // 
            this.buttonOpenOfficialDocument.Location = new System.Drawing.Point(7, 19);
            this.buttonOpenOfficialDocument.Name = "buttonOpenOfficialDocument";
            this.buttonOpenOfficialDocument.Size = new System.Drawing.Size(107, 23);
            this.buttonOpenOfficialDocument.TabIndex = 0;
            this.buttonOpenOfficialDocument.Text = "公式ドキュメント";
            this.buttonOpenOfficialDocument.UseVisualStyleBackColor = true;
            this.buttonOpenOfficialDocument.Click += new System.EventHandler(this.buttonOpenOfficialDocument_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonShowWinConvertTextAlignDuplicate);
            this.groupBox2.Controls.Add(this.buttonShowWinGetOutlinerActorLabel);
            this.groupBox2.Location = new System.Drawing.Point(13, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "便利ツール";
            // 
            // buttonShowWinConvertTextAlignDuplicate
            // 
            this.buttonShowWinConvertTextAlignDuplicate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowWinConvertTextAlignDuplicate.Location = new System.Drawing.Point(7, 47);
            this.buttonShowWinConvertTextAlignDuplicate.Name = "buttonShowWinConvertTextAlignDuplicate";
            this.buttonShowWinConvertTextAlignDuplicate.Size = new System.Drawing.Size(342, 23);
            this.buttonShowWinConvertTextAlignDuplicate.TabIndex = 3;
            this.buttonShowWinConvertTextAlignDuplicate.Text = "整列したActorを複製する";
            this.buttonShowWinConvertTextAlignDuplicate.UseVisualStyleBackColor = true;
            this.buttonShowWinConvertTextAlignDuplicate.Click += new System.EventHandler(this.buttonShowWinConvertTextAlignDuplicate_Click);
            // 
            // buttonShowWinGetOutlinerActorLabel
            // 
            this.buttonShowWinGetOutlinerActorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowWinGetOutlinerActorLabel.Location = new System.Drawing.Point(7, 18);
            this.buttonShowWinGetOutlinerActorLabel.Name = "buttonShowWinGetOutlinerActorLabel";
            this.buttonShowWinGetOutlinerActorLabel.Size = new System.Drawing.Size(342, 23);
            this.buttonShowWinGetOutlinerActorLabel.TabIndex = 2;
            this.buttonShowWinGetOutlinerActorLabel.Text = "選択しているActorのLabelを取得する";
            this.buttonShowWinGetOutlinerActorLabel.UseVisualStyleBackColor = true;
            this.buttonShowWinGetOutlinerActorLabel.Click += new System.EventHandler(this.buttonShowWinGetOutlinerActorLabel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(380, 24);
            this.menuStrip1.TabIndex = 9;
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
            // WinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 314);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinMain";
            this.Text = "PositiveUEFNUtility";
            this.Load += new System.EventHandler(this.WinMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOpenOfficialDocument;
        private System.Windows.Forms.Button buttonOpenForumLeaning;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonShowWinGetOutlinerActorLabel;
        private System.Windows.Forms.Button buttonShowWinConvertTextAlignDuplicate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDocument;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDiscord;
    }
}

