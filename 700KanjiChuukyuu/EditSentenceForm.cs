using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreService;
using CoreService.Model;

namespace _700KanjiChuukyuu
{
    public partial class EditSentenceForm : Form
    {
        private Sentence Sentence;

        public EditSentenceForm(Sentence s)
        {
            InitializeComponent();
            this.Sentence = s;
            InitializeSections();
            LoadData();
            InitializeWords();
        }

        private void InitializeSections()
        {
            List<Section> s = DataManager.Sections;
            foreach (var item in s)
            {
                this.cbxSection.Items.Add(item.Name);
            }
        }

        private void InitializeWords()
        {
            List<object> temp = DataManager.JoinWordAndPhrase();
            this.cbxWords.Items.Clear();
            foreach (var item in temp)
            {
                if (item is Word)
                    this.cbxWords.Items.Add(((Word)item).Kanji);
                else this.cbxWords.Items.Add(((Phrase)item).Word);
            }
        }

        private void LoadData()
        {
            string hightlight = "";
            foreach (var item in this.Sentence.UnderlineWords)
            {
                hightlight += item + ", ";
            }
            this.txtHighlight.Text = hightlight;
            this.txtMeaning.Text = this.Sentence.Meaning;
            this.txtSentence.Text = this.Sentence.Words;
            this.cbxSection.SelectedItem = this.Sentence.Section.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = this.Sentence.Id;
            this.Sentence = new Sentence(this.txtSentence.Text,
                this.txtHighlight.Text.Split(',', ' ').ToList(),
                this.txtMeaning.Text);
            this.Sentence.Id = id;
            this.Sentence.Section = DataManager.Sections.SingleOrDefault(q => q.Name == (string)this.cbxSection.SelectedItem);
            DataManager.UpdateSentence(this.Sentence);
        }

        private void cbxWords_KeyDown(object sender, KeyEventArgs e)
        {
            this.txtHighlight.AppendText((string)this.cbxSection.SelectedItem + ", ");
        }
    }
}
