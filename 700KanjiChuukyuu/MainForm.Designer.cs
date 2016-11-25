namespace _700KanjiChuukyuu
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
            this.menuAddSection = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choTừNgẫuNhiênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPlayGame = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.cbxSection = new System.Windows.Forms.ComboBox();
            this.listWord2 = new _700KanjiChuukyuu.Controls.CustomListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.commandToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
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
            this.menuAddSentence,
            this.menuAddSection});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(146, 22);
            this.menuAdd.Text = "Thêm từ";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuEditWord
            // 
            this.menuEditWord.Name = "menuEditWord";
            this.menuEditWord.Size = new System.Drawing.Size(146, 22);
            this.menuEditWord.Text = "Sửa từ";
            this.menuEditWord.Click += new System.EventHandler(this.menuEditWord_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // menuAddPhrase
            // 
            this.menuAddPhrase.Name = "menuAddPhrase";
            this.menuAddPhrase.Size = new System.Drawing.Size(146, 22);
            this.menuAddPhrase.Text = "Thêm cụm từ";
            this.menuAddPhrase.Click += new System.EventHandler(this.menuAddPhrase_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // menuAddSentence
            // 
            this.menuAddSentence.Name = "menuAddSentence";
            this.menuAddSentence.Size = new System.Drawing.Size(146, 22);
            this.menuAddSentence.Text = "Thêm câu";
            this.menuAddSentence.Click += new System.EventHandler(this.menuAddSentence_Click);
            // 
            // menuAddSection
            // 
            this.menuAddSection.Name = "menuAddSection";
            this.menuAddSection.Size = new System.Drawing.Size(146, 22);
            this.menuAddSection.Text = "Thêm nhóm";
            this.menuAddSection.Click += new System.EventHandler(this.menuAddSection_Click);
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
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRefresh,
            this.menuPlayGame});
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.commandToolStripMenuItem.Text = "Command";
            // 
            // menuRefresh
            // 
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.Size = new System.Drawing.Size(158, 22);
            this.menuRefresh.Text = "Refresh";
            this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click);
            // 
            // menuPlayGame
            // 
            this.menuPlayGame.Name = "menuPlayGame";
            this.menuPlayGame.Size = new System.Drawing.Size(158, 22);
            this.menuPlayGame.Text = "Chơi game nào!";
            this.menuPlayGame.Click += new System.EventHandler(this.menuPlayGame_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(124, 26);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panelDetail
            // 
            this.panelDetail.AutoScroll = true;
            this.panelDetail.Location = new System.Drawing.Point(276, 66);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(698, 484);
            this.panelDetail.TabIndex = 6;
            this.panelDetail.MouseEnter += new System.EventHandler(this.panelDetail_MouseEnter);
            this.panelDetail.MouseHover += new System.EventHandler(this.panelDetail_MouseHover);
            // 
            // cbxSection
            // 
            this.cbxSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSection.FormattingEnabled = true;
            this.cbxSection.Location = new System.Drawing.Point(142, 25);
            this.cbxSection.Name = "cbxSection";
            this.cbxSection.Size = new System.Drawing.Size(115, 28);
            this.cbxSection.TabIndex = 7;
            this.cbxSection.SelectedIndexChanged += new System.EventHandler(this.cbxSection_SelectedIndexChanged);
            // 
            // listWord2
            // 
            this.listWord2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listWord2.FormattingEnabled = true;
            this.listWord2.Location = new System.Drawing.Point(12, 66);
            this.listWord2.Name = "listWord2";
            this.listWord2.Size = new System.Drawing.Size(258, 485);
            this.listWord2.TabIndex = 8;
            this.listWord2.Click += new System.EventHandler(this.listWord_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 562);
            this.Controls.Add(this.listWord2);
            this.Controls.Add(this.cbxSection);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.txtSearch);
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
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuEditWord;
        private System.Windows.Forms.ToolStripMenuItem menuAddPhrase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuAddSentence;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem commandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.ToolStripMenuItem menuPlayGame;
        private System.Windows.Forms.ToolStripMenuItem menuAddSection;
        private System.Windows.Forms.ComboBox cbxSection;
        private Controls.CustomListBox listWord2;
    }
}

