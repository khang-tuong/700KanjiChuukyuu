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
            InitializeSections();
        }

        private void InitializeSections()
        {
            List<Section> s = DataManager.Sections;
            foreach (var item in s)
            {
                this.cbxSection.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string kanji = this.txtKanji.Text;
            string hiragana = this.txtHiragana.Text;
            string meaning = this.txtMeaning.Text;

            if (DataManager.Phrases.SingleOrDefault(q => q.Word == kanji) == null)
            {
                Phrase p = new Phrase();
                p.Hiragana = hiragana;
                p.Onyomi = this.cbxOnyomi.Checked;
                p.LinkedWord = kanji.ToCharArray().ToList();
                p.Word = kanji;
                p.Meaning = meaning;
                p.Section = DataManager.Sections.SingleOrDefault(q => q.Name == (string)this.cbxSection.SelectedItem);

                DataManager.AddPhrase(p);
            } else
            {
                MessageBox.Show("Cụm từ này có rồi!");
            }
            Reset();
        }

        private void Reset()
        {
            this.txtHiragana.Text = "";
            this.txtKanji.Text = "";
            this.txtMeaning.Text = "";
            this.cbxOnyomi.Checked = true;
            this.txtKanji.Focus();
        }

       
    }
}
