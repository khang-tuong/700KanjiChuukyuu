﻿namespace _700KanjiChuukyuu
{
    partial class MainForm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditWord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAddPhrase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAddSentence = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choTừNgẫuNhiênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listWord = new System.Windows.Forms.ListBox();
            this.txtKanji = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtSentence = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuEditWord,
            this.toolStripSeparator1,
            this.menuAddPhrase,
            this.toolStripSeparator2,
            this.menuAddSentence});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(152, 22);
            this.menuAdd.Text = "Thêm từ";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuEditWord
            // 
            this.menuEditWord.Name = "menuEditWord";
            this.menuEditWord.Size = new System.Drawing.Size(152, 22);
            this.menuEditWord.Text = "Sửa từ";
            this.menuEditWord.Click += new System.EventHandler(this.menuEditWord_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // menuAddPhrase
            // 
            this.menuAddPhrase.Name = "menuAddPhrase";
            this.menuAddPhrase.Size = new System.Drawing.Size(152, 22);
            this.menuAddPhrase.Text = "Thêm cụm từ";
            this.menuAddPhrase.Click += new System.EventHandler(this.menuAddPhrase_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // menuAddSentence
            // 
            this.menuAddSentence.Name = "menuAddSentence";
            this.menuAddSentence.Size = new System.Drawing.Size(152, 22);
            this.menuAddSentence.Text = "Thêm câu";
            this.menuAddSentence.Click += new System.EventHandler(this.menuAddSentence_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traTừToolStripMenuItem,
            this.choTừNgẫuNhiênToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // traTừToolStripMenuItem
            // 
            this.traTừToolStripMenuItem.Name = "traTừToolStripMenuItem";
            this.traTừToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.traTừToolStripMenuItem.Text = "Tra từ";
            // 
            // choTừNgẫuNhiênToolStripMenuItem
            // 
            this.choTừNgẫuNhiênToolStripMenuItem.Name = "choTừNgẫuNhiênToolStripMenuItem";
            this.choTừNgẫuNhiênToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.choTừNgẫuNhiênToolStripMenuItem.Text = "Cho từ ngẫu nhiên";
            // 
            // listWord
            // 
            this.listWord.FormattingEnabled = true;
            this.listWord.Location = new System.Drawing.Point(12, 66);
            this.listWord.Name = "listWord";
            this.listWord.Size = new System.Drawing.Size(246, 485);
            this.listWord.TabIndex = 1;
            this.listWord.Click += new System.EventHandler(this.listWord_Click);
            // 
            // txtKanji
            // 
            this.txtKanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKanji.Location = new System.Drawing.Point(296, 27);
            this.txtKanji.Name = "txtKanji";
            this.txtKanji.Size = new System.Drawing.Size(300, 234);
            this.txtKanji.TabIndex = 2;
            this.txtKanji.TextChanged += new System.EventHandler(this.txtKanji_TextChanged);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(418, 299);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(507, 20);
            this.txtTemp.TabIndex = 3;
            // 
            // txtSentence
            // 
            this.txtSentence.Location = new System.Drawing.Point(418, 367);
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.Size = new System.Drawing.Size(507, 20);
            this.txtSentence.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(246, 26);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtSentence);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtKanji);
            this.Controls.Add(this.listWord);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "700漢字中級";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traTừToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choTừNgẫuNhiênToolStripMenuItem;
        private System.Windows.Forms.ListBox listWord;
        private System.Windows.Forms.TextBox txtKanji;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuEditWord;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.ToolStripMenuItem menuAddPhrase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuAddSentence;
        private System.Windows.Forms.TextBox txtSentence;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

