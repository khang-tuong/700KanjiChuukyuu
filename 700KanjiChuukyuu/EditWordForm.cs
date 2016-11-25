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
            InitializeData();
            LoadData();
        }

        private void InitializeData()
        {
            foreach (var item in DataManager.Sections)
            {
                this.cbxSection.Items.Add(item.Name);
            }
        }

        public void LoadData()
        {
            this.txtHanViet.Text = this.Word.HanViet;
            this.txtKanji.Text = this.Word.Kanji;
            this.txtKunyomi.Text = this.Word.GetKunyomi();
            this.txtMeaning.Text = this.Word.Meaning;
            this.txtOnyomi.Text = this.Word.GetOnyomi();
            this.cbxSection.SelectedItem = (this.Word.Section != null ? this.Word.Section.Name : "");
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string r = ValidateInputs();
            if (r != null)
            {
                MessageBox.Show(r);
                return;
            }
            this.Word.HanViet = this.txtHanViet.Text;
            this.Word.Kanji = this.txtKanji.Text;
            this.Word.Kunyomi = this.txtKunyomi.Text.Split(',').ToList();
            this.Word.Meaning = this.txtMeaning.Text;
            this.Word.Onyomi = this.txtOnyomi.Text.Split(',').ToList();
            this.Word.Section = DataManager.Sections.SingleOrDefault(q => q.Name == (string)this.cbxSection.SelectedItem);
            DataManager.UpdateWordList(this.Word);
        }

        private string ValidateInputs()
        {
            if (this.txtKanji.Text.Length != 1)
            {
                return "Chỉ được nhập một chữ cái!!";
            }
            if ((string)this.cbxSection.SelectedItem == "")
            {
                return "Hãy chọn một section";
            }
            return null;
        }
    }
}
