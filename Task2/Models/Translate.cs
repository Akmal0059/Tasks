using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    public class Translate
    {
        public int FormatVersion { get; set; }
        public string Namespace { get; set; }
        public List<PhraseTranslate> Children { get; set; }
        public List<Translate> Subnamespaces { get; set; }
    }
}
