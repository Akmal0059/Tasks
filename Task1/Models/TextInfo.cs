using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class TextInfo
    {
        string text;
        int wordCount;
        int vowelsCount;
        public string Text => text;
        public int WordCount => wordCount;
        public int VowelCount => vowelsCount;

        public TextInfo(string text)
        {
            this.text = text;
            CalculateWords();
            CalculateVowels();
        }

        void CalculateWords()
        {
            wordCount = text.Split('\n', ' ').Count();
        }

        void CalculateVowels()
        {

        }
    }
}
