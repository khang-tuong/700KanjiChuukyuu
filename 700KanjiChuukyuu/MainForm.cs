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
            this.listWord.MeasureItem += ListWord_MeasureItem;
            this.listWord.DrawItem += ListWord_DrawItem;
            LoadData();
        }

        private void ListWord_DrawItem(object sender, DrawItemEventArgs e)
        {
            //Tránh lỗi lúc refresh
            if (e.Index >= 0)
            {
                // If the item is the selected item, then draw the rectangle
                // filled in blue. The item is selected when a bitwise And  
                // of the State property and the DrawItemState.Selected 
                // property is true.
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.Bounds);
                    e.Graphics.DrawString(this.listWord.Items[e.Index].ToString(),
                    new Font("HanaMinA", 14), Brushes.White, e.Bounds.X, e.Bounds.Y + 5);
                }
                else
                {
                    // Otherwise, draw the rectangle filled in beige.
                    e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                    e.Graphics.DrawString(this.listWord.Items[e.Index].ToString(),
                    new Font("HanaMinA", 14), Brushes.Black, e.Bounds.X, e.Bounds.Y + 5);
                }

                // Draw a rectangle in blue around each item.
                //e.Graphics.DrawRectangle(Pens.Blue, e.Bounds);

                // Draw the text in the item.
            

                // Draw the focus rectangle around the selected item.
                e.DrawFocusRectangle();
            }
        }

        private void ListWord_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            string itemString = (string)lb.Items[e.Index];

            // Split the string at the " . "  character.
            string[] resultStrings = itemString.Split('.');

            // If the string contains more than one period, increase the 
            // height by ten pixels; otherwise, increase the height by 
            // five pixels.
            if (resultStrings.Length > 2)
            {
                e.ItemHeight += 10;
            }
            else
            {
                e.ItemHeight += 5;
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
            string text = (string)this.listWord.SelectedItem;
            if (text.Length > 1)
            {
                Phrase p = DataManager.Phrases.SingleOrDefault(q => q.Word == text);
                if (p != null)
                {
                    ShowPhraseForm f = new ShowPhraseForm(p);
                    f.Location = new Point(15, 0);
                    this.panelDetail.Controls.Clear();
                    this.panelDetail.Controls.Add(f);
                }
            } else
            {
                Word w = DataManager.WordList.SingleOrDefault(q => q.Kanji == text);
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
            string text = (string) this.listWord.SelectedItem;
            if (text.Length > 1)
            {
                EditPhraseForm f = new EditPhraseForm(DataManager.Phrases.SingleOrDefault(q => q.Word == text));
                f.Show();
            } else
            {
                EditWordForm f = new EditWordForm(DataManager.WordList.SingleOrDefault(q => q.Kanji == text));
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
            List<string> data = DataManager.SearchWordAndPhrase(this.txtSearch.Text);
            this.ReloadListBox(data);
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
    }
}
