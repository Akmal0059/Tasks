using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Task3.Models;
using Task3.ViewModels;

namespace Task3.Commands
{
    public class CalculateCommand : ICommand
    {
        private PGViewModel viewModel;
        Dictionary<double, List<TextLine>> ruTextLines;
        Dictionary<double, List<TextLine>> enTextLines;

        public event EventHandler CanExecuteChanged;

        public CalculateCommand(PGViewModel ViewModel)
        {
            viewModel = ViewModel;
            ruTextLines = new Dictionary<double, List<TextLine>>();
            enTextLines = new Dictionary<double, List<TextLine>>();
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            foreach(var line in File.ReadAllLines(viewModel.RussianTextPath))
            {
                var textLine = new TextLine(line);
                if (ruTextLines.ContainsKey(textLine.Koef))
                    ruTextLines[textLine.Koef].Add(textLine);
                else
                    ruTextLines.Add(textLine.Koef, new List<TextLine>() { textLine });
            }

            foreach (var line in File.ReadAllLines(viewModel.EnglishTextPath))
            {
                var textLine = new TextLine(line);
                if (enTextLines.ContainsKey(textLine.Koef))
                    enTextLines[textLine.Koef].Add(textLine);
                else
                    enTextLines.Add(textLine.Koef, new List<TextLine>() { textLine });
            }

            CustomWriter writer = new CustomWriter(ruTextLines, enTextLines);
            writer.ShowResult();
        }
    }
}
