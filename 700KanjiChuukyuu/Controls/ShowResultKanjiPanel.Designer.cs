namespace _700KanjiChuukyuu.Controls
{
    partial class ShowResultKanjiPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtWordMeaning = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputMeaning = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWordHiragana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInputHiragana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKanji = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtWordMeaning
            // 
            this.txtWordMeaning.BackColor = System.Drawing.Color.White;
            this.txtWordMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordMeaning.Location = new System.Drawing.Point(576, 96);
            this.txtWordMeaning.Name = "txtWordMeaning";
            this.txtWordMeaning.ReadOnly = true;
            this.txtWordMeaning.Size = new System.Drawing.Size(150, 26);
            this.txtWordMeaning.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nghĩa đúng";
            // 
            // txtInputMeaning
            // 
            this.txtInputMeaning.BackColor = System.Drawing.Color.White;
            this.txtInputMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputMeaning.Location = new System.Drawing.Point(404, 96);
            this.txtInputMeaning.Name = "txtInputMeaning";
            this.txtInputMeaning.ReadOnly = true;
            this.txtInputMeaning.Size = new System.Drawing.Size(150, 26);
            this.txtInputMeaning.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nghĩa đã nhập";
            // 
            // txtWordHiragana
            // 
            this.txtWordHiragana.BackColor = System.Drawing.Color.White;
            this.txtWordHiragana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordHiragana.Location = new System.Drawing.Point(576, 18);
            this.txtWordHiragana.Name = "txtWordHiragana";
            this.txtWordHiragana.ReadOnly = true;
            this.txtWordHiragana.Size = new System.Drawing.Size(150, 26);
            this.txtWordHiragana.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hiragana đúng";
            // 
            // txtInputHiragana
            // 
            this.txtInputHiragana.BackColor = System.Drawing.Color.White;
            this.txtInputHiragana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputHiragana.Location = new System.Drawing.Point(404, 18);
            this.txtInputHiragana.Name = "txtInputHiragana";
            this.txtInputHiragana.ReadOnly = true;
            this.txtInputHiragana.Size = new System.Drawing.Size(150, 26);
            this.txtInputHiragana.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hiragana đã nhập";
            // 
            // txtKanji
            // 
            this.txtKanji.BackColor = System.Drawing.Color.White;
            this.txtKanji.Font = new System.Drawing.Font("HanaMinB", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKanji.Location = new System.Drawing.Point(3, 3);
            this.txtKanji.Name = "txtKanji";
            this.txtKanji.ReadOnly = true;
            this.txtKanji.Size = new System.Drawing.Size(392, 118);
            this.txtKanji.TabIndex = 9;
            // 
            // ShowResultKanjiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtWordMeaning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInputMeaning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWordHiragana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInputHiragana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKanji);
            this.Name = "ShowResultKanjiPanel";
            this.Size = new System.Drawing.Size(737, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWordMeaning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputMeaning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWordHiragana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInputHiragana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKanji;
    }
}
