using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Task3.ViewModels;

namespace Task3.Commands
{
    public class SaveCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;
        private OutputViewModel viewModel;

        public SaveCommand(OutputViewModel ViewModel)
        {
            viewModel = ViewModel;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();

            using (StreamWriter writer = new StreamWriter(dialog.FileName))
            {
                writer.Write(viewModel.OutputText);
            }
        }
    }
}
