using System;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;

namespace Cirilizator
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnSekvencijalno_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Selection sel = Globals.ThisAddIn.Application.Selection;
            string original = sel.Text;

            if (!string.IsNullOrWhiteSpace(original))
            {
                string konvertovano = Cirilizator.SekvencijalnaKonverzija(original);
                sel.Text = konvertovano;
            }
        }

        private void btnParalelno_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Selection sel = Globals.ThisAddIn.Application.Selection;
            string original = sel.Text;

            if (!string.IsNullOrWhiteSpace(original))
            {
                string konvertovano = Cirilizator.ParalelnaKonverzija(original);
                sel.Text = konvertovano;
            }
        }

        private void btnAutomatski_Click(object sender, RibbonControlEventArgs e)
        {
            Word.Selection sel = Globals.ThisAddIn.Application.Selection;
            string original = sel.Text;

            if (!string.IsNullOrWhiteSpace(original))
            {
                string konvertovano = Cirilizator.AutomatskaKonverzija(original);
                sel.Text = konvertovano;
            }
        }
    }
}
