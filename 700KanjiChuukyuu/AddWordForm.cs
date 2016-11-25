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
            InitializeData();
        }

        private void InitializeData()
        {
            foreach (var item in DataManager.Sections)
            {
                this.cbxSection.Items.Add(item.Name);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string r = ValidateInputs();
            if (r != null)
            {
                MessageBox.Show(r);
                return;
            }
            string kanji = this.txtKanji.Text;
            if (DataManager.WordList.SingleOrDefault(q => q.Kanji == kanji) == null)
            {
                string hanviet = this.txtHanViet.Text;
                List<string> kunyomi = this.txtKunyomi.Text.Replace('、', ',').Split(',').ToList();
                List<string> onyomi = this.txtOnyomi.Text.Replace('、', ',').Split(',').ToList();
                string meaning = this.txtMeaning.Text;
                Word w = new Word(kanji, meaning, onyomi, kunyomi, hanviet);
                w.Section = DataManager.Sections.SingleOrDefault(q => q.Name == (string)this.cbxSection.SelectedItem);
                DataManager.AddWord(w);
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
            this.txtKanji.Focus();
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
