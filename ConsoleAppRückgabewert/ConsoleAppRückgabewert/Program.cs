using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRückgabewert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(MethodeRückgabewert(20, 30));
            //Console.ReadKey();

            Console.WriteLine("Geben Sie eine ganze Zahl ein");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie eine ganze Zahl ein");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Summe: " + MethodeRückgabewert(a, b));
        }

        private static int x, y, z;

        private static int MethodeRückgabewert(int zahl1, int zahl2) //Eingabe
        {
            x = zahl1;
            y = zahl2;
            z = x + y;
            return z;
        }
    }
}