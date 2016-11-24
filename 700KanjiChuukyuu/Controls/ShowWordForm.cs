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
    public partial class ShowWordForm : UserControl
    {
        private Word Word;
        public ShowWordForm(Word w)
        {
            InitializeComponent();
            this.Word = w;
            LoadData();
        }

        public void LoadData()
        {
            if (this.Word != null)
            {
                this.txtHanViet.Text = this.Word.HanViet;
                this.txtKanji.Text = this.Word.Kanji;
                this.txtKunyomi.Text = this.Word.GetKunyomi();
                this.txtMeaning.Text = this.Word.Meaning;
                this.txtOnyomi.Text = this.Word.GetOnyomi();
                List<Phrase> phrases = DataManager.GetPhrasesContainWord(this.Word);
                List<Sentence> sentences = DataManager.GetSentencesContainsPhrasesList(phrases);

                ShowPhrases(phrases);
                ShowSentences(sentences);
            }
        }

        private void ShowPhrases(List<Phrase> phrases)
        {
            int y = this.lbExSentences.Location.Y + this.lbExPhrases.Height + 5;
            foreach (var item in phrases)
            {
                TextBox txt = new TextBox();
                txt.Text = item.Word + " - " + item.Meaning;
                txt.Location = new Point(this.lbOnyomi.Location.X, y);
                txt.Width = 300;
                txt.Font = new Font("Ms Mincho", 12);
                txt.ReadOnly = true;
                txt.BackColor = Color.White;
                txt.BorderStyle = BorderStyle.None;
                this.panelPhrases.Controls.Add(txt);
                y += txt.Height + 5;
            }
            this.panelPhrases.Location = new Point(this.txtKanji.Location.X, this.panelMean.Location.Y + this.panelMean.Height + 7);
        }

        private void ShowSentences(List<Sentence> sentences)
        {
            int y = this.lbExSentences.Location.Y + this.lbExSentences.Height + 5;
            foreach (var item in sentences)
            {
                TextBox txt = new TextBox();
                txt.Text = item.Words;
                txt.Location = new Point(this.lbOnyomi.Location.X, y);
                txt.Width = this.Width - 62;
                txt.WordWrap = true;
                txt.Multiline = true;
                txt.Font = new Font("Ms Mincho", 12);
                txt.BorderStyle = BorderStyle.None;
                txt.ReadOnly = true;
                txt.BackColor = Color.White;
                this.panelSentences.Controls.Add(txt);
                y += txt.Height + 5;
            }
            this.panelSentences.Location = new Point(this.panelPhrases.Location.X, this.panelPhrases.Location.Y + this.panelPhrases.Height + 7);
        }
    }
}
