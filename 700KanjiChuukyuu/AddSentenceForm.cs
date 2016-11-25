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
            Sentence s = new Sentence(this.txtSentence.Text, 
                this.txtHighlight.Text.Replace('、', ',').Split(',').ToList(), 
                this.txtAnswer.Text.Replace('、', ',').Split(',').ToList(),
                this.txtMeaning.Text);
            s.Section = DataManager.Sections.SingleOrDefault(q => q.Name == (string)this.cbxSection.SelectedItem);
            DataManager.AddSentence(s);
        }
    }
}
