using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3.Models
{
    public class TextLine
    {
        private double koef;
        private string text;
        private string comment;
        private string cgangedText;

        public double Koef => koef;
        public string Text => text;
        public string Comment => comment;

        public TextLine(string text)
        {
            this.text = text;
            var splitedText = text.Split('|');
            cgangedText = splitedText[0];
            if (splitedText.Count() == 2)
                comment = splitedText[1];
            koef = 0;
            RemoveDividingChars();
            CalculatePetrenkoKoef();
        }

        void CalculatePetrenkoKoef()
        {
            int length = cgangedText.Length;
            double sum = (double)(length * length) / 2;
            koef = sum * length;
        }

        void RemoveDividingChars()
        {
            cgangedText = Regex.Replace(cgangedText, "(?i)[^А-ЯЁA-Z]", "");
        }
    }
}
