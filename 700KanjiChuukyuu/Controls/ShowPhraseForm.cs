using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreService.Model;
using CoreService;

namespace _700KanjiChuukyuu.Controls
{
    public partial class ShowPhraseForm : UserControl
    {
        private Phrase Phrase;
        public MainForm MainForm;

        public ShowPhraseForm(Phrase p)
        {
            InitializeComponent();
            this.Phrase = p;
            LoadData();
        }

        public void LoadData()
        {
            if (this.Phrase != null)
            {
                this.txtKanji.Text = this.Phrase.Word;
                this.txtMeaning.Text = this.Phrase.Meaning;
                this.txtOnyomi.Text = this.Phrase.Hiragana;
                List<Sentence> sentences = DataManager.GetSentencesContainPhrase(this.Phrase);

                ShowSentences(sentences);
            }
        }

        private void ShowSentences(List<Sentence> sentences)
        {
            this.panelSentences.Width = this.panelMean.Width;
            int y = this.lbExSentences.Location.Y + this.lbExSentences.Height + 5;
            foreach (var item in sentences)
            {
                Panel p = new Panel();
                p.AutoSize = true;
                p.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                //Sentence
                TextBox txt = new TextBox();
                txt.Text = item.Words + "\r\n" + item.Meaning;
                txt.Location = new Point(this.lbOnyomi.Location.X, y);
                txt.Width = this.Width - 62;
                txt.WordWrap = true;
                txt.Multiline = true;
                txt.Font = new Font("Microsoft Sans Serif", 12);
                txt.BorderStyle = BorderStyle.None;
                txt.ReadOnly = true;
                txt.BackColor = Color.White;
                txt.Height = 50;
                p.Controls.Add(txt);

                //Linked words
                int labelX = this.lbOnyomi.Location.X;
                foreach (var word in item.UnderlineWords)
                {
                    Label lb = new Label();
                    lb.Text = word;
                    lb.ForeColor = Color.CornflowerBlue;
                    lb.Cursor = Cursors.Hand;
                    lb.Location = new Point(labelX, txt.Height + txt.Location.Y + 5);
                    lb.Font = new Font("Microsoft Sans Serif", 10);
                    lb.Width = TextRenderer.MeasureText(word, lb.Font).Width;
                    lb.Click += Lb_Click;
                    labelX += lb.Width + 10;
                    p.Controls.Add(lb);
                }
                y += p.Height + 10;
                this.panelSentences.Controls.Add(p);
            }
            this.panelSentences.Location = new Point(this.panelMean.Location.X, this.panelMean.Location.Y + this.panelMean.Height + 7);
        }

        private void Lb_Click(object sender, EventArgs e)
        {
            this.MainForm.SearchPhrase(((Label)sender).Text);
        }
    }
}
