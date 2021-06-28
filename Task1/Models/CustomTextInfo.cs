using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class CustomTextInfo : INotifyPropertyChanged
    {
        string text;
        int wordCount;
        int vowelsCount;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Text 
        {
            get => text;
            set
            {
                text = value;
                OnPropertyCahnegd();
            }
        }
        public int WordCount
        {
            get => wordCount;
            set
            {
                wordCount = value;
                OnPropertyCahnegd();
            }
        }
        public int VowelCount
        {
            get => vowelsCount;
            set
            {
                vowelsCount = value;
                OnPropertyCahnegd();
            }
        }

        public CustomTextInfo(string text)
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
            vowelsCount = text.Count(x => VowelSounds.IsVowel(x));
        }

        //update ui, if DataSource is changed
        void OnPropertyCahnegd([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
