using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    }
}
