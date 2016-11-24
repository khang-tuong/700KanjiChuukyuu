using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreService.Model;
using CoreService;

namespace _700KanjiChuukyuu
{
    public partial class EditPhraseForm : Form
    {

        private Phrase Phrase;

        public EditPhraseForm(Phrase p)
        {
            InitializeComponent();
            this.Phrase = p;
            LoadData();
        }

        public void LoadData()
        {
            this.txtHiragana.Text = this.Phrase.Hiragana;
            this.txtKanji.Text = this.Phrase.Word;
            this.txtMeaning.Text = this.Phrase.Meaning;
            this.cbxOnyomi.Checked = this.Phrase.Onyomi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Phrase.Meaning = this.txtMeaning.Text;
            this.Phrase.Hiragana = this.txtHiragana.Text;
            this.Phrase.Word = this.txtKanji.Text;
            this.Phrase.LinkedWord = this.Phrase.Word.ToCharArray().ToList();
            this.Phrase.Onyomi = this.cbxOnyomi.Checked;
            this.Phrase.Id = this.Phrase.Id;

            DataManager.UpdatePhrase(this.Phrase);
            //Reset();
            this.Dispose();
        }

        private void Reset()
        {
            this.txtHiragana.Text = "";
            this.txtKanji.Text = "";
            this.txtMeaning.Text = "";
            this.cbxOnyomi.Checked = true;
        }
    }
}
