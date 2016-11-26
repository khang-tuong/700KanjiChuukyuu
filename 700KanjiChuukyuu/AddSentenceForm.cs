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
    public partial class AddSentenceForm : Form
    {
        public AddSentenceForm()
        {
            InitializeComponent();
            InitializeSections();
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
            this.cbxWords.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cbxWords.MaxDropDownItems = 5;
            List<object> temp = DataManager.JoinWordAndPhrase();
            this.cbxWords.Items.Clear();
            foreach (var item in temp)
            {
                if (item is Word)
                    this.cbxWords.Items.Add(((Word)item).Kanji);
                else this.cbxWords.Items.Add(((Phrase)item).Word);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sentence s = new Sentence(this.txtSentence.Text, 
                this.txtHighlight.Text.Split(',', ' ').ToList(), 
                this.txtMeaning.Text);
            s.Section = DataManager.Sections.SingleOrDefault(q => q.Name == (string)this.cbxSection.SelectedItem);
            DataManager.AddSentence(s);
            Reset();
        }

        private void cbxWords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtHighlight.AppendText((string)this.cbxWords.SelectedText + ", ");
            }
        }

        private void Reset()
        {
            this.txtHighlight.Text = "";
            this.txtMeaning.Text = "";
            this.txtSentence.Text = "";
            this.txtSentence.Focus();
        }
    }
}
