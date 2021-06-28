using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Task1.Commands;
using Task1.Interfaces;
using Task1.ViewModels;

namespace Task1.Views
{
    /// <summary>
    /// Interaction logic for WordCounterUI.xaml
    /// </summary>
    public partial class WordCounterUI : Window, IView
    {
        public WordCounterUI()
        {
            InitializeComponent();
            DataContext = new WordCounterViewModel(this);
        }

        //public void AppendColoredText(string text, SolidColorBrush color)
        //{
        //    var paragraph = RTB_Identifier.Document.Blocks.FirstOrDefault() as Paragraph;
        //    //RTB_Identifier.Document = new FlowDocument(paragraph);

        //    paragraph.Inlines.Add(new Bold(new Run(text))
        //    {
        //        Foreground = color
        //    });
        //}

        //public void ClearInputBox()
        //{
        //    RTB_Identifier.Document.Blocks.Clear();
        //    RTB_Identifier.Document.Blocks.Add(new Paragraph());
        //}

        //public string GetText() => new TextRange(RTB_Identifier.Document.ContentStart, RTB_Identifier.Document.ContentEnd).Text;
    }
}
