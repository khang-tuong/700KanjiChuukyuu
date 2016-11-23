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
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string kanji = this.txtKanji.Text;
            if (DataManager.WordList.SingleOrDefault(q => q.Kanji == kanji) == null)
            {
                string hanviet = this.txtHanViet.Text;
                List<string> kunyomi = this.txtKunyomi.Text.Replace('、', ',').Split(',').ToList();
                List<string> onyomi = this.txtOnyomi.Text.Replace('、', ',').Split(',').ToList();
                string meaning = this.txtMeaning.Text;
                Word w = new Word(kanji, meaning, onyomi, kunyomi, hanviet);
                DataManager.WordList.Add(w);
                FileManager.WriteWordFile();
                Reset();
            } else
            {
                MessageBox.Show("Từ này có rồi!");
            }

        }

        private void Reset()
        {
            this.txtHanViet.Text = "";
            this.txtKanji.Text = "";
            this.txtKunyomi.Text = "";
            this.txtMeaning.Text = "";
            this.txtOnyomi.Text = "";
        }
    }
}
