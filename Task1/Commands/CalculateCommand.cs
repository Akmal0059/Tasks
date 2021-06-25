using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Text.Json;
using Newtonsoft.Json;
using Task1.Models;

namespace Task1.Commands
{
    public class CalculateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            //string[] ids = ((string)parameter).Split(';');
            string id = (string)parameter;
            string url = $"http://tmgwebtest.azurewebsites.net/api/textstrings/{id}";
            var client = new WebClient();
            client.Headers.Add("TMG-Api-Key", "0J/RgNC40LLQtdGC0LjQutC4IQ==");
            
            var result = client.DownloadString(url);
            TextInfo account = JsonConvert.DeserializeObject<TextInfo>(result);
        }
    }
}
