using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class VowelSounds
    {
        static char[] russianVowels = new char[10]
        {
            'а', 'у', 'о', 'ы', 'и', 'э', 'я', 'ю', 'ё', 'е'
        };

        static char[] englishVowels = new char[5]
        {
            'a','e','i','o','u'
        };

        public static bool IsVowel(char c) => russianVowels.Contains(c) || englishVowels.Contains(c);
    }
}
