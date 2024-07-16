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
            this.buttonShowWinGetOutlinerActorLabel = new System.Windows.Forms.Button();
            this.buttonShowWinConvertTextAlignDuplicate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonOpenForumLeaning);
            this.groupBox1.Controls.Add(this.buttonOpenOfficialDocument);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
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
            this.groupBox2.Location = new System.Drawing.Point(13, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "便利ツール";
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
            // WinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 280);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinMain";
            this.Text = "PositiveUEFNUtility";
            this.Load += new System.EventHandler(this.WinMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOpenOfficialDocument;
        private System.Windows.Forms.Button buttonOpenForumLeaning;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonShowWinGetOutlinerActorLabel;
        private System.Windows.Forms.Button buttonShowWinConvertTextAlignDuplicate;
    }
}

