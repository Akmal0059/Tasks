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
using Task1.ViewModels;
using System.Windows.Media;
using System.Windows;
using System.Windows.Documents;
using Task1.Interfaces;

namespace Task1.Commands
{
    public class CalculateCommand : ICommand
    {
        WordCounterViewModel viewModel;
        IView iView;
        public event EventHandler CanExecuteChanged;

        public CalculateCommand(WordCounterViewModel ViewModel, IView iView)
        {
            viewModel = ViewModel;
            this.iView = iView;
        }

        public bool CanExecute(object parameter) => viewModel.IsServerAvailable();

        public void Execute(object parameter)
        {
            var client = new WebClient();
            client.Headers.Add("TMG-Api-Key", "0J/RgNC40LLQtdGC0LjQutC4IQ==");
            List<string> errorIds = new List<string>();
            //iView.ClearInputBox();

            //handling all inputed identidiers
            foreach (string id in viewModel.Ids.Distinct())
            {
                if (string.IsNullOrEmpty(id))
                    continue;
                //iView.AppendColoredText(id, Brushes.Red);
                int IntId = -1;
                if (!int.TryParse(id, out IntId))
                {
                    errorIds.Add(id);
                    continue;
                }
                if (IntId < 1 || IntId > 20)
                {
                    errorIds.Add(id);
                    continue;
                }

                string url = $"http://tmgwebtest.azurewebsites.net/api/textstrings/{IntId}";
                var result = client.DownloadString(url);
                CustomTextInfo cti = JsonConvert.DeserializeObject<CustomTextInfo>(result);
                viewModel.TextInformations.Add(cti);
            }
            if (errorIds.Count > 0)
                MessageBox.Show($"Следующие идентификаторы некорректны:\n\n{string.Join(',', errorIds)}", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
