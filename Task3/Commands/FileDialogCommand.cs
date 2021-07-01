using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Task3.ViewModels;

namespace Task3.Commands
{
    public class FileDialogCommand : ICommand
    {
        private PGViewModel viewModel;
        public event EventHandler CanExecuteChanged;

        public FileDialogCommand(PGViewModel ViewModel)
        {
            viewModel = ViewModel;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (parameter.ToString() == "ru")
                viewModel.RussianTextPath = ofd.FileName;
            else if(parameter.ToString() == "en")
                viewModel.EnglishTextPath = ofd.FileName;
        }
    }
}
