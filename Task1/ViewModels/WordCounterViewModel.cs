using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Task1.Commands;
using Task1.Interfaces;
using Task1.Models;
using Task1.Views;

namespace Task1.ViewModels
{
    public class WordCounterViewModel : INotifyPropertyChanged
    {
        ObservableCollection<CustomTextInfo> textsInfo;
        string strIds;
        public event PropertyChangedEventHandler PropertyChanged;
        IView view;

        public ObservableCollection<CustomTextInfo> TextInformations
        {
            get => textsInfo;
            set
            {
                textsInfo = value;
                OnPropertyCahnegd();
            }
        }
        public string StringIdentifies
        {
            get => strIds;
            set
            {
                strIds = value;
                OnPropertyCahnegd();
            }
        } //view.GetText();
        public ObservableCollection<string> Ids => new ObservableCollection<string>(StringIdentifies?.Replace(" ", "").Split(';', ','));
        public ICommand CalcCommand { get; set; }


        public WordCounterViewModel(IView view)
        {
            this.view = view;
            textsInfo = new ObservableCollection<CustomTextInfo>();
            CalcCommand = new CalculateCommand(this, view);
        }

        public bool IsServerAvailable()
        {
            try
            {
                var client = new WebClient();
                client.Headers.Add("TMG-Api-Key", "0J/RgNC40LLQtdGC0LjQutC4IQ==");
                string url = $"http://tmgwebtest.azurewebsites.net/api/textstrings/17";
                var result = client.DownloadString(url);
                return true;
            }
            catch
            {
                return false;
            }


        }
        void OnPropertyCahnegd([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
