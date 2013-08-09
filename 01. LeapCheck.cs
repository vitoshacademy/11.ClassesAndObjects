//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
// DateTime.IsLeap(); returns bool  => so it is really easy!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LeapCheck
{
    static void Main()
    {
        Console.WriteLine("Which year do you want to check? ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("The year {0} is Leap!", year);
        }
        else
        {
            Console.WriteLine("The year {0} is NOT Leap!", year);
        }

    }
}
