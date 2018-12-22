using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1Naloga1
{
    class Program
    {
        static void Main(string[] args)
        {
            PoisciVse(30, 50);
            Console.ReadKey();
        }

        static void PoisciVse(int a, int b)
        {
            for (; a <= b; a++)
            {
                int i = a;
                while (i != 1)
                {
                    if (i % 2 == 0) i /= 2;
                    else i = 3 * i + 1;
                    if (i >= 9232)
                    {
                        Console.Write(a + " ");
                    }
                }
            }
        }
    }
}
