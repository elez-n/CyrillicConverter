using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cirilizator
{
    internal class Cirilizator
    {
        private static readonly Dictionary<string, string> latinToCyrillic = new Dictionary<string, string>()
        {
            { "A", "А" }, { "B", "Б" }, { "C", "Ц" }, { "Č", "Ч" }, { "Ć", "Ћ" }, { "D", "Д" },
            { "Đ", "Ђ" }, { "E", "Е" }, { "F", "Ф" }, { "G", "Г" }, { "H", "Х" }, { "I", "И" },
            { "J", "Ј" }, { "K", "К" }, { "L", "Л" }, { "M", "М" }, { "N", "Н" }, { "O", "О" },
            { "P", "П" }, { "R", "Р" }, { "S", "С" }, { "Š", "Ш" }, { "T", "Т" }, { "U", "У" },
            { "V", "В" }, { "Z", "З" }, { "Ž", "Ж" },
            { "a", "а" }, { "b", "б" }, { "c", "ц" }, { "č", "ч" }, { "ć", "ћ" }, { "d", "д" },
            { "đ", "ђ" }, { "e", "е" }, { "f", "ф" }, { "g", "г" }, { "h", "х" }, { "i", "и" },
            { "j", "ј" }, { "k", "к" }, { "l", "л" }, { "m", "м" }, { "n", "н" }, { "o", "о" },
            { "p", "п" }, { "r", "р" }, { "s", "с" }, { "š", "ш" }, { "t", "т" }, { "u", "у" },
            { "v", "в" }, { "z", "з" }, { "ž", "ж" }
        };

        private static readonly Dictionary<string, string> izuzeci = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "nadživjeti", "надживјети" },
            { "konjunkcija", "конјункција" },
            { "injekcija", "инјекција" }
        };

        private static string ObradiIzuzetke(string tekst)
        {
            foreach (var par in izuzeci)
            {
                tekst = Regex.Replace(tekst, $@"\b{Regex.Escape(par.Key)}(?=\b|\W)", match =>
                {
                    string original = match.Value;
                    string zamjena = par.Value;

                    if (char.IsUpper(original[0]))
                        zamjena = char.ToUpper(zamjena[0]) + zamjena.Substring(1);

                    return zamjena;
                }, RegexOptions.IgnoreCase);
            }

            return tekst;
        }

        private static string ZamijeniDvoslovneSekvence(string tekst)
        {
            return tekst
                .Replace("Dž", "Џ").Replace("dž", "џ")
                .Replace("Lj", "Љ").Replace("lj", "љ")
                .Replace("Nj", "Њ").Replace("nj", "њ");
        }

        public static string SekvencijalnaKonverzija(string tekst)
        {
            Stopwatch sw = Stopwatch.StartNew();

            string obracunato = ObradiIzuzetke(tekst);
            obracunato = ZamijeniDvoslovneSekvence(obracunato);

            var sb = new StringBuilder();
            foreach (char c in obracunato)
            {
                string s = c.ToString();
                if (latinToCyrillic.TryGetValue(s, out string cir))
                    sb.Append(cir);
                else
                    sb.Append(c);
            }

            sw.Stop();
            MessageBox.Show($"[SekvencijalnaKonverzija] Trajanje: {sw.Elapsed.TotalMilliseconds:F3} ms");
            return sb.ToString();
        }

        public static string ParalelnaKonverzija(string tekst)
        {
            Stopwatch sw = Stopwatch.StartNew();

            string obracunato = ObradiIzuzetke(tekst);
            obracunato = ZamijeniDvoslovneSekvence(obracunato);

            char[] rezultat = new char[obracunato.Length];
            Parallel.For(0, obracunato.Length, i =>
            {
                string s = obracunato[i].ToString();
                rezultat[i] = latinToCyrillic.TryGetValue(s, out string cir) ? cir[0] : obracunato[i];
            });

            sw.Stop();
            MessageBox.Show($"[ParalelnaKonverzija] Trajanje: {sw.Elapsed.TotalMilliseconds:F3} ms");
            return new string(rezultat);
        }

        public static string AutomatskaKonverzija(string tekst)
        {
            int brojJezgara = Environment.ProcessorCount;
            int prag = Math.Max(brojJezgara * 4000, 15000);

            if (tekst.Length >= prag)
            {
                return ParalelnaKonverzija(tekst);
            }
            else
            {
                return SekvencijalnaKonverzija(tekst);
            }
        }
    }
}
