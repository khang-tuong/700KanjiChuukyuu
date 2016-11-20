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
    public partial class AddWordForm : Form
    {
        public AddWordForm()
        {
            InitializeComponent();
            InitializePlaceholder();
        }

        private void InitializePlaceholder()
        {
            Font f = new Font("MS Sans Serif", 11, FontStyle.Italic);
            this.txtHanViet.Font = this.txtKanji.Font = this.txtKunyomi.Font = this.txtMeaning.Font = this.txtOnyomi.Font = f;
            this.txtHanViet.ForeColor = Color.Gray;
            this.txtHanViet.Text = "Tiếng Hán Việt";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string kanji = this.txtKanji.Text;
            if (DataManager.WordList.SingleOrDefault(q => q.Kanji == kanji) == null)
            {
                string hanviet = this.txtHanViet.Text;
                string kunyomi = this.txtKunyomi.Text;
                string onyomi = this.txtOnyomi.Text;
                string meaning = this.txtMeaning.Text;
                Word w = new Word(kanji, meaning, onyomi, kunyomi, hanviet);
                DataManager.WordList.Add(w);
                FileManager.WriteWordFile();
            }

        }
    }
}
