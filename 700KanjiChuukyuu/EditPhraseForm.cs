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
            InitializeSections();
            LoadData();
        }

        private void InitializeSections()
        {
            List<Section> s = DataManager.Sections;
            foreach (var item in s)
            {
                this.cbxSection.Items.Add(item.Name);
            }
        }

        public void LoadData()
        {
            this.txtHiragana.Text = this.Phrase.Hiragana;
            this.txtKanji.Text = this.Phrase.Word;
            this.txtMeaning.Text = this.Phrase.Meaning;
            this.cbxOnyomi.Checked = this.Phrase.Onyomi;
            this.cbxSection.SelectedItem = (this.Phrase.Section != null ? this.Phrase.Section.Name : "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Phrase.Meaning = this.txtMeaning.Text;
            this.Phrase.Hiragana = this.txtHiragana.Text;
            this.Phrase.Word = this.txtKanji.Text;
            this.Phrase.LinkedWord = this.Phrase.Word.ToCharArray().ToList();
            this.Phrase.Onyomi = this.cbxOnyomi.Checked;
            this.Phrase.Id = this.Phrase.Id;
            this.Phrase.Section = DataManager.Sections.SingleOrDefault(q => q.Name == (string)this.cbxSection.SelectedItem);

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
