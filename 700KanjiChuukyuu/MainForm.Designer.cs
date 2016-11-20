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
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choTừNgẫuNhiênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listWord = new System.Windows.Forms.ListBox();
            this.txtKanji = new System.Windows.Forms.TextBox();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.sửaTừToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
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
            this.listWord.Location = new System.Drawing.Point(12, 27);
            this.listWord.Name = "listWord";
            this.listWord.Size = new System.Drawing.Size(246, 524);
            this.listWord.TabIndex = 1;
            // 
            // txtKanji
            // 
            this.txtKanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKanji.Location = new System.Drawing.Point(518, 27);
            this.txtKanji.Name = "txtKanji";
            this.txtKanji.Size = new System.Drawing.Size(300, 234);
            this.txtKanji.TabIndex = 2;
            this.txtKanji.TextChanged += new System.EventHandler(this.txtKanji_TextChanged);
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(152, 22);
            this.menuAdd.Text = "Thêm từ";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // sửaTừToolStripMenuItem
            // 
            this.sửaTừToolStripMenuItem.Name = "sửaTừToolStripMenuItem";
            this.sửaTừToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sửaTừToolStripMenuItem.Text = "Sửa từ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
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
        private System.Windows.Forms.ToolStripMenuItem sửaTừToolStripMenuItem;
    }
}

