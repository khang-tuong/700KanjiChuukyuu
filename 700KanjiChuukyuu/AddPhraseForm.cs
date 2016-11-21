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
    public partial class AddPhraseForm : Form
    {
        public AddPhraseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kanji = this.txtKanji.Text;
            string hiragana = this.txtHiragana.Text;
            string meaning = this.txtMeaning.Text;

            Phrase p = new Phrase();
            p.Hiragana = hiragana;
            p.Onyomi = this.cbxOnyomi.Checked;
            p.LinkedWord = kanji.ToCharArray().ToList();
            p.Word = kanji;

            DataManager.Phrases.Add(p);
            FileManager.WritePhraseFile();
        }
    }
}
