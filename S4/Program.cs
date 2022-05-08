using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int Fn = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int Sn = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int Tn = int.Parse(Console.ReadLine());
            int ave = (Fn + Sn + Tn) / 3;
            Console.WriteLine("Average numders: " + ave);
            Console.ReadKey();
        }
    }
}
