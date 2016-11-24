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
        public static List<Section> Sections = new List<Section>();

        public DataManager()
        {
        }

        

        #region ADD
        public static void AddSentence(Sentence s)
        {
            s.Id = Sentences.Count;
            Sentences.Add(s);
            FileManager.WriteSentenceFile();
        }

        public static void AddPhrase(Phrase p)
        {
            p.Id = Phrases.Count;
            Phrases.Add(p);
            FileManager.WritePhraseFile();
        }

        public static void AddWord(Word w)
        {
            w.Id = WordList.Count;
            WordList.Add(w);
            FileManager.WriteWordFile();
        }

        public static void AddSection(Section s)
        {
            s.Id = Sections.Count;
            Sections.Add(s);
            FileManager.WriteSectionFile();
        }
        #endregion

        #region UPDATE

        public static void UpdateSentence(Sentence s)
        {
            Sentence sentence = DataManager.Sentences.SingleOrDefault(q => q.Id == s.Id);
            sentence = s;
            FileManager.WriteSentenceFile();
        }

        public static void UpdateWordList(Word w)
        {
            Word word = DataManager.WordList.SingleOrDefault(q => q.Id == w.Id);
            word = w;
            FileManager.WriteWordFile();
        }

        public static void UpdatePhrase(Phrase p)
        {
            Phrase phrase= DataManager.Phrases.SingleOrDefault(q => q.Id == p.Id);
            phrase = p;
            FileManager.WritePhraseFile();
        }

        public static void UpdateSection(Section s)
        {
            Section section = DataManager.Sections.SingleOrDefault(q => q.Id == s.Id);
            section = s;
            FileManager.WriteSectionFile();
        }

        #endregion

        #region DELETE

        public static void DeleteWord(Word w)
        {
            int id = w.Id;
            DataManager.WordList.Remove(w);
            int length = WordList.Count;
            for (int i = id - 1; i < length; i++)
            {
                --WordList[i].Id;
            }
            FileManager.WriteWordFile();
        }

        public static void DeletePhrase(Phrase p)
        {
            int id = p.Id;
            DataManager.Phrases.Remove(p);
            int length = Phrases.Count;
            for (int i = id - 1; i < length; i++)
            {
                --Phrases[i].Id;
            }
            FileManager.WritePhraseFile();
        }

        public static void DeleteSentence(Sentence s)
        {
            int id = s.Id;
            DataManager.Sentences.Remove(s);
            int length = Sentences.Count;
            for (int i = id - 1; i < length; i++)
            {
                --Sentences[i].Id;
            }
            FileManager.WriteSentenceFile();
        }

        public static void DeleteSection(Section s)
        {
            int id = s.Id;
            DataManager.Sections.Remove(s);
            int length = Sections.Count;
            for (int i = id - 1; i < length; i++)
            {
                --Sections[i].Id;
            }
            WordList.Where(q => q.Section.Id == id).ToList().ForEach( q => q.Section = null);
            Sentences.Where(q => q.Section.Id == id).ToList().ForEach(q => q.Section = null);
            Phrases.Where(q => q.Section.Id == id).ToList().ForEach(q => q.Section = null);
            
            FileManager.WriteSectionFile();
            FileManager.WritePhraseFile();
            FileManager.WriteSentenceFile();
            FileManager.WriteWordFile();
        }

        #endregion


        public static List<Sentence> GetSentencesContainPhrase(Phrase p)
        {
            var r = Sentences.Where(q => q.UnderlineWords.Contains(p.Word)).ToList();
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
                    temp.Add(item.Kanji);
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
