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

namespace _700KanjiChuukyuu
{
    public partial class MainForm : Form
    {
        public DataManager dataManager;

        public MainForm()
        {
            InitializeComponent();
            this.dataManager = new DataManager();
            LoadData();
        }

        private void txtKanji_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtKanji.Text))
            {
                Size size = TextRenderer.MeasureText(this.txtKanji.Text, this.txtKanji.Font);
                this.txtKanji.Width = size.Width;
                this.txtKanji.Left = (this.Width - this.listWord.Width - this.txtKanji.Width) / 2 + this.listWord.Width;
            }
        }

        private void LoadData()
        {
            string r = FileManager.ReadWordFile();
            if (!string.IsNullOrEmpty(r))
            {
                MessageBox.Show(r, "Có lỗi xảy ra");
            }
            r = FileManager.ReadPhraseFile();
            if (!string.IsNullOrEmpty(r))
            {
                MessageBox.Show(r, "Có lỗi xảy ra");
            }
            foreach (var item in DataManager.WordList)
            {
                this.listWord.Font = new Font("MS Mincho", 14);
                this.listWord.Items.Add(item.Kanji + " - " + item.HanViet);
            }
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            AddWordForm f = new AddWordForm();
            f.Show();
        }

        private void listWord_Click(object sender, EventArgs e)
        {
            char c = ((string) this.listWord.SelectedItem)[0];
            string t = DataManager.Phrases.Where(q => q.LinkedWord.Contains(c)).ToList()[0].Word;
            this.txtTemp.Text = t;
        }

        private void menuAddPhrase_Click(object sender, EventArgs e)
        {
            AddPhraseForm f = new AddPhraseForm();
            f.Show();
        }
    }
}
