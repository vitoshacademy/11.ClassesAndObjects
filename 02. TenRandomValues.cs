//Write a program that generates and prints to the console 10 random values in the range [100, 200].


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.WriteLine("Random numbers between 100 and 200:");
        Console.WriteLine();
        Random randomNumber = new Random();
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Random number " +i+ " => {0}", randomNumber.Next(100, 201));
        }
        Console.WriteLine();
    }
}

