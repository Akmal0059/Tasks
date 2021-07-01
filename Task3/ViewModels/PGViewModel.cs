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
    public class PGViewModel : INotifyPropertyChanged
    {
        string ruTextPath;
        string enTextPath;

        public ICommand FileDialogCommand { get; set; }
        public ICommand CalculateCommand { get; set; }
        public string RussianTextPath 
        {
            get => ruTextPath;
            set
            {
                ruTextPath = value;
                OnPropertyChnaged();
            }
        }
        public string EnglishTextPath 
        {
            get => enTextPath;
            set
            {
                enTextPath = value;
                OnPropertyChnaged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public PGViewModel()
        {
            FileDialogCommand = new FileDialogCommand(this);
            CalculateCommand = new CalculateCommand(this);
        }


        void OnPropertyChnaged([CallerMemberName]string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
