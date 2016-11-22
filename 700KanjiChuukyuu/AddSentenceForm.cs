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
    public partial class AddSentenceForm : Form
    {
        public AddSentenceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sentence s = new Sentence(this.txtSentence.Text, this.txtHighlight.Text.Split(',').ToList(), this.txtAnswer.Text.Split(',').ToList());
            DataManager.AddSentence(s);
        }
    }
}
