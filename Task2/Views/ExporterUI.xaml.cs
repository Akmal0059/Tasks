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
using System.Text.Json;
using System.IO;
using Task2.Models;
using Task2.ModelViews;

namespace Task2.Views
{
    /// <summary>
    /// Interaction logic for ExporterUI.xaml
    /// </summary>
    public partial class ExporterUI : Window
    {
        public ExporterUI()
        {
            InitializeComponent();
            DataContext = new ExporterViewModel();
        }
    }
}
