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
    }
}
