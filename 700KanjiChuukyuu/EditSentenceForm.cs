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
        }

        private void InitializeSections()
        {
            List<Section> s = DataManager.Sections;
            foreach (var item in s)
            {
                this.cbxSection.Items.Add(item.Name);
            }
        }

        private void LoadData()
        {
            string answer = "";
            string underlined = "";
            for (int i = 0; i < this.Sentence.Answers.Count; i++)
            {
                answer += this.Sentence.Answers[i] + ", ";
                underlined += this.Sentence.UnderlineWords[i] + ", ";
            }
            this.txtAnswer.Text = answer;
            this.txtHighlight.Text = underlined;
            this.txtMeaning.Text = this.Sentence.Meaning;
            this.txtSentence.Text = this.Sentence.Words;
            this.cbxSection.SelectedItem = this.Sentence.Section.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = this.Sentence.Id;
            this.Sentence = new Sentence(this.txtSentence.Text,
                this.txtHighlight.Text.Replace('、', ',').Split(',').ToList(),
                this.txtAnswer.Text.Replace('、', ',').Split(',').ToList(),
                this.txtMeaning.Text);
            this.Sentence.Id = id;
            this.Sentence.Section = DataManager.Sections.SingleOrDefault(q => q.Name == (string)this.cbxSection.SelectedItem);
            DataManager.UpdateSentence(this.Sentence);
        }
    }
}
