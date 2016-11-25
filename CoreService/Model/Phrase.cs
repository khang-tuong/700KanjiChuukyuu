using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreService.Model
{
    [Serializable]
    public class Phrase
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public bool Onyomi { get; set; }
        public string Hiragana { get; set; }
        public List<char> LinkedWord { get; set; }
        public string Meaning { get; set; }
        public Section Section { get; set; }

        public override string ToString()
        {
            return this.Word + "\n" + this.Meaning;
        }
    }
}
