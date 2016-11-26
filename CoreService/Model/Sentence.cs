using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreService.Model
{
    [Serializable]
    public class Sentence
    {
        public int Id { get; set; }
        public string Words { get; set; }
        public List<string> UnderlineWords { get; set; }
        public string Meaning { get; set; }
        public Section Section { get; set; }


        public Sentence(string w, List<string> highlight, string meaning)
        {
            this.Words = w;
            this.UnderlineWords = highlight;
            this.Meaning = meaning;
        }
    }
}
