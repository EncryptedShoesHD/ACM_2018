using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skupina1Naloga3
{
    class Skupina1Naloga3
    {
        static void Main(string[] args)
        {
            // Branje števila koščkov
            Console.Write("Vpišite število koščkov: ");
            int steviloKosckov;
            while(!int.TryParse(Console.ReadLine(), out steviloKosckov) && steviloKosckov <= 0)
            {
                Console.Write("Vpišite veljavno število koščkov: ");
            }

            // Branje željenega razmerja
            Console.Write("Vpišite razmerje (lahko je decimalno število): ");
            float razmerje;
            while (!float.TryParse(Console.ReadLine(), out razmerje) && razmerje <= 0.0f)
            {
                Console.Write("Vpišite veljavno razmerje: ");
            }

            // Računanje optimalne velikosti sestavljanke za dano razmerje
            Console.WriteLine("Optimalna velikost sestavljanke z " + steviloKosckov + " kosi je: " + Sestavljanka(steviloKosckov, razmerje));

            Console.ReadKey();
        }

        static string Sestavljanka(int steviloKosckov, float razmerje)
        {
            float najboljseRazmerje = razmerje + 1;
            string output = "";
            for(int i = 1; i < steviloKosckov / 2; i++)
            {
                if(steviloKosckov % i == 0)
                {
                    float trenutnoRazmerje = 0.0f;
                    if(i < (steviloKosckov / i))
                    {
                        trenutnoRazmerje = (float) i / (steviloKosckov / i);
                        Console.WriteLine(trenutnoRazmerje);
                        if(Math.Abs(razmerje - trenutnoRazmerje) < najboljseRazmerje) {
                            najboljseRazmerje = Math.Abs(razmerje - trenutnoRazmerje);
                            output = i + " * " + (steviloKosckov / i) + " (" + trenutnoRazmerje + ")";
                        }
                    }
                }
            }
            return output;
        }
    }
}
