using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zad._10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] c = new int[(int)char.MaxValue];
            string tekst = File.ReadAllText(@"c:\tmp\opowiadanie.txt");
            foreach (char znak in tekst)
            {
                c[(int)znak]++;
            }
            string nazwa = @"c:\tmp\znaki.txt";
            FileStream plik = new FileStream(nazwa, FileMode.Create, FileAccess.Write, FileShare.None);
            System.IO.StreamWriter zapis = new StreamWriter(plik);
            zapis.Write("znak:częstotliwość   ");
            for (i = 0; i < (int)char.MaxValue; i++)
            {
                if (c[i] > 0 && char.IsLetterOrDigit((char)i))
                {
                    zapis.Write("{0}:{1}   ", (char)i, c[i]);
                }
            }
            zapis.Close();
            plik.Close();
        }
    }
}
