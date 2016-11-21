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
    public partial class EditWordForm : Form
    {

        public Word Word;

        public EditWordForm(Word w)
        {
            this.Word = w;
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            this.txtHanViet.Text = this.Word.HanViet;
            this.txtKanji.Text = this.Word.Kanji;
            this.txtKunyomi.Text = this.Word.GetKunyomi();
            this.txtMeaning.Text = this.Word.Meaning;
            this.txtOnyomi.Text = this.Word.GetOnyomi();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Word.HanViet = this.txtHanViet.Text;
            this.Word.Kanji = this.txtKanji.Text;
            this.Word.Kunyomi = this.txtKunyomi.Text.Split(',').ToList();
            this.Word.Meaning = this.txtMeaning.Text;
            this.Word.Onyomi = this.txtOnyomi.Text.Split(',').ToList();
            DataManager.UpdateWordList(this.Word);
        }
    }
}
