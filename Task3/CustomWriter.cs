using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;
using Task3.Views;
using TextLine = Task3.Models.TextLine;

namespace Task3
{
    public class CustomWriter
    {
        Dictionary<double, List<TextLine>> ruTextLines;
        Dictionary<double, List<TextLine>> enTextLines;

        public CustomWriter(Dictionary<double, List<TextLine>> ruTextLine, Dictionary<double, List<TextLine>> enTextLine)
        {
            this.ruTextLines = ruTextLine;
            this.enTextLines = enTextLine;
        }

        public void ShowResult()
        {
            string OutputText = "";
            foreach (var txtLineKeyValue in ruTextLines)
            {
                if (!enTextLines.ContainsKey(txtLineKeyValue.Key))
                {
                    foreach (var txtLine in txtLineKeyValue.Value)
                        OutputText += txtLine.Text + "\n\n";
                }
                else
                {
                    foreach (var txtLine in txtLineKeyValue.Value)
                    {
                        OutputText += txtLine.Text + "\n";
                        foreach (var enTxtLine in enTextLines[txtLineKeyValue.Key])
                            OutputText += "\t-" + enTxtLine.Text + "\n";
                        OutputText += "\n";
                    }
                }
            }
            OutputUI outputUI = new OutputUI(OutputText);
            outputUI.ShowDialog();
        }
    }
}
