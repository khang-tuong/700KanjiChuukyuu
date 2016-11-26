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
            r = FileManager.ReadSectionFile();
            if (!string.IsNullOrEmpty(r))
            {
                MessageBox.Show(r, "Có lỗi xảy ra");
            }
            List<object> temp = DataManager.JoinWordAndPhrase();
            ReloadListBox(temp);
            ReLoadComboBox();
        }

        private void ReloadListBox(List<object> data)
        {
            this.listWord2.Items.Clear();
            foreach (var item in data)
            {
                if (item is Word)
                    this.listWord2.AddWord((Word)item);
                else this.listWord2.AddPhrasse((Phrase)item);
            }
        }

        private void ReLoadComboBox()
        {
            List<Section> sections = DataManager.Sections;
            this.cbxSection.Items.Clear();
            this.cbxSection.Items.Add("--Section--");
            foreach (var item in sections)
            {
                this.cbxSection.Items.Add(item.Name);
            }
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            AddWordForm f = new AddWordForm();
            f.Show();
        }

        private void listWord_Click(object sender, EventArgs e)
        {
            object obj = this.listWord2.SelectedItem;
            if (obj is Phrase)
            {
                Phrase p = (Phrase)obj;
                Phrase p2 = DataManager.Phrases.SingleOrDefault(q => q.Id == p.Id);
                if (p != null)
                {
                    ShowPhraseForm f = new ShowPhraseForm(p);
                    f.Location = new Point(15, 0);
                    this.panelDetail.Controls.Clear();
                    this.panelDetail.Controls.Add(f);
                }
            } else
            {
                Word w = (Word)obj;
                Word w2 = DataManager.WordList.SingleOrDefault(q => q.Id == w.Id);
                if (w != null)
                {
                    ShowWordForm f = new ShowWordForm(w);
                    f.Location = new Point(15, 0);
                    this.panelDetail.Controls.Clear();
                    this.panelDetail.Controls.Add(f);
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
            object obj = this.listWord2.SelectedItem;
            if (obj is Phrase)
            {
                EditPhraseForm f = new EditPhraseForm(DataManager.Phrases.SingleOrDefault(q => q.Id == ((Phrase)obj).Id));
                f.Show();
            } else
            {
                EditWordForm f = new EditWordForm(DataManager.WordList.SingleOrDefault(q => q.Id == ((Word)obj).Id));
                f.Show();
            }
        }

        private void menuAddSentence_Click(object sender, EventArgs e)
        {
            AddSentenceForm f = new AddSentenceForm();
            f.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string name = (string)this.cbxSection.SelectedItem;
            Section s = DataManager.Sections.SingleOrDefault(q => q.Name == name);
            List<object> obj = DataManager.SearchWordAndPhrase(this.txtSearch.Text, s);
            this.ReloadListBox(obj);
        }

        private void menuRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void menuPlayGame_Click(object sender, EventArgs e)
        {

        }

        private void panelDetail_MouseEnter(object sender, EventArgs e)
        {
            this.panelDetail.Focus();
        }

        private void panelDetail_MouseHover(object sender, EventArgs e)
        {
            this.panelDetail.Focus();
        }

        private void menuAddSection_Click(object sender, EventArgs e)
        {
            AddSectionForm f = new AddSectionForm();
            f.Show();
        }

        private void cbxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender, e);
        }
    }
}
