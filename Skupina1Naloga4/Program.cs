using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skupina1Naloga4
{
    class Program
    {
        static int max = 250;
        static int kazalec = 0;
        static int zacetek = max;
        static int hitrost = 0;

        static void Main(string[] args)
        {
            Random rnd = new Random();
            while(true)
            {
                hitrost = rnd.Next(0, 301);
                Console.WriteLine(Premik(hitrost) + " , " + hitrost + " , " + kazalec);
                System.Threading.Thread.Sleep(500);
            }
        }

        static int Premik(int hitrost)
        {
            if(zacetek > 0)
            {
                zacetek--;
                return -1;
            }

            if(hitrost > max)
            {
                hitrost = max;
            }

            int premik;
            if (hitrost > kazalec) premik = 1;
            else if (hitrost < kazalec) premik = -1;
            else premik = 0;

            kazalec += premik;
            return premik;
        }
    }
}
