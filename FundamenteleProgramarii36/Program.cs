using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
36.Scrie o metodă care primește ca parametru un număr natural x și apoi afișează: 
-cifrele numărului(în ordine inversă)
-suma cifrelor

Ex: n == 21304
    Cifrele numărului sunt: 4, 0, 3, 1, 2,
    Suma cifrelor este: 10
*/
namespace FundamenteleProgramarii36
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input lui x
            int x;
            Console.WriteLine("Dati o valuare lui x: ");
            x = int.Parse(Console.ReadLine());

            afisare(x);
            Console.ReadLine();
        }
        static void afisare(int x)
        {
            int s = 0;
            Console.Write("Cifrele numarului sunt:");
            while (x != 0)
            {
                if (x >= 10)
                    Console.Write(" {0},", x % 10);
                else
                    Console.Write(" {0}.", x % 10);
                s = s + x % 10;
                x /= 10;
            }
            Console.WriteLine("\nSuma cifrelor este: {0}", s);
        }
    }
}

