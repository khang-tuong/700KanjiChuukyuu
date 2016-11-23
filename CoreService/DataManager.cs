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
        public static List<Sentence> Sentences = new List<Sentence>();

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

        public static void AddSentence(Sentence s)
        {
            Sentences.Add(s);
            FileManager.WriteSentenceFile();
        }

        public static List<string> GetSentencesContainPhrase(string p)
        {
            List<string> r = new List<string>();
            foreach (var item in Sentences)
            {
                if (item.UnderlineWords.Contains(p))
                {
                    r.Add(item.Words);
                }
            }
            return r;
        }

        public static List<string> JoinWordAndPhrase()
        {
            List<string> temp = new List<string>();
            foreach (var item in WordList)
            {
                temp.Add(item.Kanji);
            }
            foreach (var item in Phrases)
            {
                temp.Add(item.Word);
            }
            return temp.OrderBy(q => q.Trim()).ToList();
        }

        public static List<string> SearchWordAndPhrase(string key)
        {
            List<string> temp = new List<string>();
            foreach (var item in WordList)
            {
                if (item.Kanji.Contains(key) || item.HanViet.Contains(key))
                {
                    temp.Add(item.Kanji + " - " + item.HanViet);
                }
            }
            foreach (var item in Phrases)
            {
                if (item.Word.Contains(key))
                {
                    temp.Add(item.Word);
                }
            }
            return temp.OrderBy(q => q.Trim()).ToList();
        }

        public static List<Phrase> GetPhrasesContainWord(Word w)
        {
            var r = Phrases.Where(q => q.LinkedWord.Contains(w.Kanji[0])).ToList();
            return r;
        }

        public static List<Sentence> GetSentecesContainWord(Word w)
        {
            var r = Sentences.Where(q => q.UnderlineWords.Contains(w.Kanji)).ToList();
            return r;
        }

        public static List<Sentence> GetSentencesContainsPhrasesList(List<Phrase> phrases)
        {
            var r = new List<Sentence>();
            foreach (var item in phrases)
            {
                var temp = Sentences.Where(q => q.UnderlineWords.Contains(item.Word)).ToList();
                if (temp != null) r.AddRange(temp);
            }
            return r;
        }
    }
}
