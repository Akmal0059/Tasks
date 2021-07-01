﻿using System;
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
using Task3.ViewModels;

namespace Task3.Views
{
    /// <summary>
    /// Interaction logic for OutputUI.xaml
    /// </summary>
    public partial class OutputUI : Window
    {
        public OutputUI(string Text)
        {
            InitializeComponent();
            DataContext = new OutputViewModel(Text);
        }
    }
}
