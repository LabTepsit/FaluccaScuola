using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 55555;
            Console.WriteLine($"il valore di a è {a.ToString()}");
            short s = (short)a;
            Console.WriteLine($"Il valore di s è {s.ToString()}");
            Console.ReadLine();
        }
    }
}
