using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _700KanjiChuukyuu.Controls
{
    public partial class ShowResultKanjiPanel : UserControl
    {
        public ShowResultKanjiPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="kanji"></param>
        /// <param name="inputHiragana"></param>
        /// <param name="wordHiragana"></param>
        /// <param name="inputMeaning"></param>
        /// <param name="wordMeaning"></param>
        public void SetupInformation(string kanji, string inputHiragana, string wordHiragana, string inputMeaning, string wordMeaning)
        {
            this.txtKanji.Text = kanji;
            this.txtInputHiragana.Text = inputHiragana;
            this.txtInputMeaning.Text = inputMeaning;
            this.txtWordHiragana.Text = wordHiragana;
            this.txtWordMeaning.Text = wordMeaning;
        }
    }
}
