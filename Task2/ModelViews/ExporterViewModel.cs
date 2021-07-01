using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Task2.Commads;

namespace Task2.ModelViews
{
    public class ExporterViewModel
    {
        public string FilePath { get; set; }
        public ICommand FileDialogCommand { get; set; }
        public ICommand ExportToExcelCommand { get; set; }
        public ICommand SerializeExcelFileCommad { get; set; }

        public ExporterViewModel()
        {
            FileDialogCommand = new FileDialogCommand();
            ExportToExcelCommand = new ExportToExcelCommand();
            SerializeExcelFileCommad = new SerializeExcelFileCommand();
        }
    }
}
