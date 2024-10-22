﻿namespace PositiveUEFNUtility
{
    partial class WinGetOutlinerActorLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinGetOutlinerActorLabel));
            this.textBoxSrcText = new System.Windows.Forms.TextBox();
            this.textBoxDestText = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConvertClipboard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDiscord = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSrcText
            // 
            this.textBoxSrcText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSrcText.Location = new System.Drawing.Point(6, 42);
            this.textBoxSrcText.MaxLength = 1000000;
            this.textBoxSrcText.Multiline = true;
            this.textBoxSrcText.Name = "textBoxSrcText";
            this.textBoxSrcText.Size = new System.Drawing.Size(312, 331);
            this.textBoxSrcText.TabIndex = 0;
            // 
            // textBoxDestText
            // 
            this.textBoxDestText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDestText.Location = new System.Drawing.Point(405, 42);
            this.textBoxDestText.MaxLength = 10000000;
            this.textBoxDestText.Multiline = true;
            this.textBoxDestText.Name = "textBoxDestText";
            this.textBoxDestText.Size = new System.Drawing.Size(291, 331);
            this.textBoxDestText.TabIndex = 2;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConvert.Location = new System.Drawing.Point(324, 42);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 43);
            this.buttonConvert.TabIndex = 1;
            this.buttonConvert.Text = ">変換>";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "UEFN情報";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "ActorLabel";
            // 
            // buttonConvertClipboard
            // 
            this.buttonConvertClipboard.Location = new System.Drawing.Point(14, 36);
            this.buttonConvertClipboard.Name = "buttonConvertClipboard";
            this.buttonConvertClipboard.Size = new System.Drawing.Size(244, 52);
            this.buttonConvertClipboard.TabIndex = 0;
            this.buttonConvertClipboard.Text = "クリップボード変換";
            this.buttonConvertClipboard.UseVisualStyleBackColor = true;
            this.buttonConvertClipboard.Click += new System.EventHandler(this.buttonConvertClipboard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxSrcText);
            this.groupBox1.Controls.Add(this.textBoxDestText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonConvert);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "テキストボックス";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 8;
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
            // WinGetOutlinerActorLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 484);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonConvertClipboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinGetOutlinerActorLabel";
            this.Text = "WinGetOutlinerActorLabel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSrcText;
        private System.Windows.Forms.TextBox textBoxDestText;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConvertClipboard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDocument;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDiscord;
    }
}