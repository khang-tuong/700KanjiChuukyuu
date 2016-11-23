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
using _700KanjiChuukyuu.Controls;

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
            r = FileManager.ReadSentenceFile();
            if (!string.IsNullOrEmpty(r))
            {
                MessageBox.Show(r, "Có lỗi xảy ra");
            }
            List<string> temp = DataManager.JoinWordAndPhrase();
            ReloadListBox(temp);
        }

        private void ReloadListBox(List<string> data)
        {
            this.listWord.Items.Clear();
            foreach (var item in data)
            {
                this.listWord.Font = new Font("MS Mincho", 14);
                this.listWord.ItemHeight = 30;
                this.listWord.Items.Add(item);
            }
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            AddWordForm f = new AddWordForm();
            f.Show();
        }

        private void listWord_Click(object sender, EventArgs e)
        {
            string c = ((string) this.listWord.SelectedItem).Split(' ').ToList()[0];
            Word w = DataManager.WordList.SingleOrDefault(q => q.Kanji == c);
            if (w != null)
            {
                ShowWordForm f = new ShowWordForm(w);
                f.Location = new Point(0, 0);
                this.panelDetail.Controls.Clear();
                this.panelDetail.Controls.Add(f);
            } else
            {
                Phrase p = DataManager.Phrases.SingleOrDefault(q => q.Word == c);
                if (p != null)
                {

                }
            }
        }

        private void menuAddPhrase_Click(object sender, EventArgs e)
        {
            AddPhraseForm f = new AddPhraseForm();
            f.Show();
        }

        private void menuEditWord_Click(object sender, EventArgs e)
        {
            char c = ((string)this.listWord.SelectedItem)[0];
            EditWordForm f = new EditWordForm(DataManager.WordList.SingleOrDefault(q => q.Kanji == c.ToString()));
            f.Show();
        }

        private void menuAddSentence_Click(object sender, EventArgs e)
        {
            AddSentenceForm f = new AddSentenceForm();
            f.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<string> data = DataManager.SearchWordAndPhrase(this.txtSearch.Text);
            this.ReloadListBox(data);
        }

        private void menuRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
