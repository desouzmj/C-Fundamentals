using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial =1;
            Console.WriteLine("Enter factorial to calculate: ");
            string x = Console.ReadLine();
            int n = int.Parse(x);
            int i;

            for (i=n; i>1; i=i-1)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial: {0}", factorial);
            Console.ReadLine();
        }
    }
}
