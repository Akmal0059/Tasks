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

namespace Task1.Views
{
    /// <summary>
    /// Interaction logic for WordCounterUI.xaml
    /// </summary>
    public partial class WordCounterUI : Window
    {
        public List<Test> Tests { get; set; }
        public ICommand CalcCommand { get; set; }
        public WordCounterUI()
        {
            Tests = new List<Test>()
            {
                new Test()
                {
                    Name = "123",
                    Age = 1
                },
                new Test()
                {
                    Name = "123",
                    Age = 1
                },new Test()
                {
                    Name = "123",
                    Age = 1
                }
            };
            CalcCommand = new CalculateCommand();
            InitializeComponent();
            DataContext = this;
        }
    }
    public class Test
    {
        public string Name { get; set; }
        public int Age { get; set; }


    }
}
