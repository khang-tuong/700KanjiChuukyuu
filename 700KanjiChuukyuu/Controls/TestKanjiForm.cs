using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreService;
using CoreService.Model;

namespace _700KanjiChuukyuu.Controls
{
    public partial class TestKanjiForm : Form
    {
        private List<Phrase> phrases = new List<Phrase>();
        private int current = 0;
        private List<string> hiragana = new List<string>();
        private List<string> meaning = new List<string>();
        public TestKanjiForm()
        {
            InitializeComponent();
            InitializeSections();
        }

        private void InitializeSections()
        {
            foreach (var item in DataManager.Sections)
            {
                this.cbxSection.Items.Add(item.Name);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string section = (string)this.cbxSection.SelectedItem;
            this.phrases = DataManager.GetPhraseInSection(section);
            Play();
        }

        private void Play()
        {
            Utils.Shuffle(this.phrases);
            this.lbKanji.Text = ((Phrase)this.phrases[0]).Word;
            ++current;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.hiragana.Add(this.txtHiragana.Text);
            this.meaning.Add(this.txtMeaning.Text);
            this.txtHiragana.ResetText();
            this.txtMeaning.ResetText();
            if (current < this.phrases.Count)
            {
                this.lbKanji.Text = ((Phrase)this.phrases[this.current]).Word;
                ++current;
            } else
            {
                ShowResultTestKanji f = new ShowResultTestKanji(this.phrases, this.hiragana, this.meaning);
                f.Show();
            }
        }
    }
}
