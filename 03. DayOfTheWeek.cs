/*Write a program that prints to the console which day of the week is today. 
 * Use System.DateTime.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine("Today is {0}.", today.DayOfWeek);
        if (DateTime.Today.DayOfWeek.Equals(DayOfWeek.Monday))
        {
            Console.WriteLine("I Love Mondays");
        }
        else if (DateTime.Today.DayOfWeek.Equals(DayOfWeek.Tuesday))
        {
            Console.WriteLine("Four days left until Friday");
        }
        else if (DateTime.Today.DayOfWeek.Equals(DayOfWeek.Friday))
        {
            Console.WriteLine("F - R - I - D - A - Y!");
        }
        else if (DateTime.Today.DayOfWeek.Equals(DayOfWeek.Saturday)||DateTime.Today.DayOfWeek.Equals(DayOfWeek.Sunday))
        {
            Console.WriteLine("Enjoy your weekend");
        }
        else
        {
            Console.WriteLine("There is nothing special about Wednesday or Thursday!");
        }
    }
}
