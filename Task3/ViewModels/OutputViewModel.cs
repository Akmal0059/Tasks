using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Task3.Commands;

namespace Task3.ViewModels
{
    public class OutputViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string outputText;

        public string OutputText 
        {
            get => outputText;
            set
            {
                outputText = value;
                OnPropertyChnaged();
            }
        }
        public ICommand SaveCommand { get; set; }

        public OutputViewModel(string text)
        {
            outputText = text;
            SaveCommand = new SaveCommand(this);
        }

        void OnPropertyChnaged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
