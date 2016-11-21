using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreService.Model;

namespace CoreService
{
    public class DataManager
    {
        public static List<Word> WordList = new List<Word>();
        public static List<Phrase> Phrases = new List<Phrase>();

        public DataManager()
        {
        }

        public static void UpdateWordList(Word w)
        {
            int length = WordList.Count;
            for (int i = 0; i < length; i++)
            {
                if (WordList[i].Kanji == w.Kanji)
                {
                    WordList[i] = w;
                    break;
                }
            }
            FileManager.WriteWordFile();
        }
    }
}
