using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int leftover;
            int secpermin = 60;
            int secperhour = secpermin * secpermin;
            int secperday = secperhour*24;
            Console.Write("Enter number of seconds: ");
            string strseconds = Console.ReadLine();
            int seconds = int.Parse(strseconds);
            int days = Math.DivRem(seconds, secperday, out leftover);
            int hours = Math.DivRem(leftover, secperhour, out leftover);
            int minutes = Math.DivRem(leftover, secpermin, out leftover);
            Console.Write("{0} days, {1} hours, {2} minutes, {3} seconds", days, hours, minutes, leftover);
            Console.ReadLine();
        }
    }
}
