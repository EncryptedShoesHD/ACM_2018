using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skupina1Naloga2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesite besedilo, ki ga je potrebno dešifrirati.");
            Decode(Console.ReadLine());
            Console.ReadKey(true);
        }

        static void Decode(string s)
        {
            string[,] polje = new string[2, 26] { { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" }, { "ALFA", "BRAVO", "CHARLIE", "DELTA", "ECHO", "FOXTROT", "GOLF", "HOTEL", "INDIA", "JULIET", "KILO", "LIMA", "MIKE", "NOVEMBER", "OSCAR", "PAPA", "QUEBEC", "ROMEO", "SIERRA", "TANGO", "UNIFORM", "VICTOR", "WHISKY", "X-RAY", "YANKEE", "ZULU" } };
            string[] besede = s.Split(' ');
            for (int i = 0; i < besede.Length; i++) //Vsaka beseda
            {
                int mestoBesede = -1;
                for (int j = 0; j < polje.GetLength(1); j++)
                {
                    if (polje[1, j].Equals(besede[i]))
                    {
                        mestoBesede = j;
                        break;
                    }
                }
                if (mestoBesede != -1) Console.Write(polje[0, mestoBesede]); //Beseda se 100% ujema
                else //Primerjava vsake beseda z dano besedo iz vhoda
                {
                    mestoBesede = -1;
                    float ujemanje = 0.0f;
                    for (int j = 0; j < polje.GetLength(1); j++)
                    {
                        int stUjemanj = 0;

                        //Iskanje krajše in daljše besede
                        string krajsa, daljsa;
                        if (besede[i].Length <= polje[1, j].Length)
                        {
                            krajsa = besede[i];
                            daljsa = polje[1, j];
                        }
                        else
                        {
                            krajsa = polje[1, j];
                            daljsa = besede[i];
                        }

                        //Primerjava vsakega znaka med krajšo in daljšo besedo
                        for (int k = 0; k < krajsa.Length; k++)
                        {
                            if (krajsa[k].Equals(daljsa[k])) stUjemanj++;
                        }

                        //Po potrebi spremenimo spremenljivko največjega ujemanja, zato da dobimo najustreznejšo besedo
                        if (ujemanje < ((float)100 / daljsa.Length * stUjemanj))
                        {
                            ujemanje = ((float)100 / daljsa.Length * stUjemanj);
                            mestoBesede = j;
                        }
                    }
                    if (mestoBesede != -1)
                    {
                        Console.Write(polje[0, mestoBesede]);
                    }
                }
            }
        }
    }
}
