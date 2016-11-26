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
            int y = this.lbExSentences.Location.Y + this.lbExSentences.Height + 5;
            foreach (var item in sentences)
            {
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
                this.panelSentences.Controls.Add(txt);
                y += txt.Height + 10;
            }
            this.panelSentences.Location = new Point(this.panelMean.Location.X, this.panelMean.Location.Y + this.panelMean.Height + 7);
        }
    }
}
