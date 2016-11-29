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

namespace _700KanjiChuukyuu.Controls
{
    public partial class ShowResultTestKanji : Form
    {
        private List<Phrase> phrases = new List<Phrase>();
        private List<string> hiragana = new List<string>();
        private List<string> meaning = new List<string>();
        public ShowResultTestKanji(List<Phrase> phrases, List<string> hiragana, List<string> meaning)
        {
            this.phrases = phrases;
            this.hiragana = hiragana;
            this.meaning = meaning;
            InitializeComponent();
            InitializeResult();
        }

        private void InitializeResult()
        {
            int x = 15;
            int y = 17;
            int length = this.phrases.Count;
            for (int i = 0; i < length; i++)
            {
                ShowResultKanjiPanel p = new ShowResultKanjiPanel();
                p.SetupInformation(this.phrases[i].Word, this.hiragana[i], this.phrases[i].Hiragana, this.meaning[i], this.phrases[i].Meaning);
                p.Location = new Point(x, y);
                this.panelMain.Controls.Add(p);
                y += p.Height + 20;
            }
        }
    }
}
