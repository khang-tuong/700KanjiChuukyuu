﻿namespace _700KanjiChuukyuu
{
    partial class EditWordForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.txtHanViet = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtOnyomi = new System.Windows.Forms.TextBox();
            this.txtKunyomi = new System.Windows.Forms.TextBox();
            this.txtKanji = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Âm Hán Việt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nghĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Âm Nhật";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Âm Hán";
            // 
            // txtMeaning
            // 
            this.txtMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeaning.Location = new System.Drawing.Point(60, 249);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(228, 26);
            this.txtMeaning.TabIndex = 21;
            // 
            // txtHanViet
            // 
            this.txtHanViet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHanViet.Location = new System.Drawing.Point(386, 249);
            this.txtHanViet.Name = "txtHanViet";
            this.txtHanViet.Size = new System.Drawing.Size(215, 26);
            this.txtHanViet.TabIndex = 20;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(257, 302);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(103, 36);
            this.btnDone.TabIndex = 19;
            this.btnDone.Text = "Hoàn tất";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtOnyomi
            // 
            this.txtOnyomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOnyomi.Location = new System.Drawing.Point(60, 188);
            this.txtOnyomi.Name = "txtOnyomi";
            this.txtOnyomi.Size = new System.Drawing.Size(228, 29);
            this.txtOnyomi.TabIndex = 18;
            // 
            // txtKunyomi
            // 
            this.txtKunyomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKunyomi.Location = new System.Drawing.Point(386, 188);
            this.txtKunyomi.Name = "txtKunyomi";
            this.txtKunyomi.Size = new System.Drawing.Size(215, 29);
            this.txtKunyomi.TabIndex = 17;
            // 
            // txtKanji
            // 
            this.txtKanji.Enabled = false;
            this.txtKanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKanji.Location = new System.Drawing.Point(12, 12);
            this.txtKanji.Name = "txtKanji";
            this.txtKanji.Size = new System.Drawing.Size(589, 158);
            this.txtKanji.TabIndex = 16;
            // 
            // EditWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 353);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.txtHanViet);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtOnyomi);
            this.Controls.Add(this.txtKunyomi);
            this.Controls.Add(this.txtKanji);
            this.Name = "EditWordForm";
            this.Text = "EditWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.TextBox txtHanViet;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtOnyomi;
        private System.Windows.Forms.TextBox txtKunyomi;
        private System.Windows.Forms.TextBox txtKanji;
    }
}