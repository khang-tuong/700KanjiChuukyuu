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
            Phrase p = DataManager.Phrases.SingleOrDefault(q => q.Id == this.Phrase.Id);
            if (p != null)
            {
                p.Meaning = this.txtMeaning.Text;
                p.Hiragana = this.txtHiragana.Text;
                p.LinkedWord = p.Word.ToCharArray().ToList();
                p.Onyomi = this.cbxOnyomi.Checked;

                FileManager.WritePhraseFile();
                Reset();
            }
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
