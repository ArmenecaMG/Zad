using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete chislo");
            int number = int.Parse(Console.ReadLine());
            int sum = SumOfDigits(number);
            Console.WriteLine($"Sumata na chislata e : {sum} ");
        }
        static int SumOfDigits(int n)
        {
            if (n < 0) n = -n;
            if(n == 0) return 0;
            return (n%10) + SumOfDigits(n/10);
        }
    }
}
