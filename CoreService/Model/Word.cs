using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreService.Model
{
    [Serializable]
    public class Word
    {
        public int Id { get; set; }
        public string Kanji { get; set; }
        public string Meaning { get; set; }
        public List<string> Onyomi { get; set; }
        public List<string> Kunyomi { get; set; }
        public string HanViet { get; set; }
        public Section Section { get; set; }

        public Word() { }

        public Word(string kanji, string meaning, List<string> onyomi, List<string> kunyomi, string hanviet)
        {
            this.Onyomi = onyomi;
            this.Kunyomi = kunyomi;
            this.Kanji = kanji;
            this.Meaning = meaning;
            this.HanViet = hanviet;
        }

        public string GetKunyomi()
        {
            string s = "";
            foreach (string item in Kunyomi)
            {
                s += item + ", "; 
            }
            return s.Substring(0, s.Length - 2);
        }

        public string GetOnyomi()
        {
            string s = "";
            foreach (string item in Onyomi)
            {
                s += item + ", ";
            }
            return s.Substring(0, s.Length - 2);
        }
    }
}
