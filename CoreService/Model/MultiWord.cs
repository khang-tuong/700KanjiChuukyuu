using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreService.Model
{
    [Serializable]
    public class MultiWord
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public bool Kunyomi { get; set; }
        public string Hiragana { get; set; }
        public List<string> LinkedWord { get; set; }
    }
}
