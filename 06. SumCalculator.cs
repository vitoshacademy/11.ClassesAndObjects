/*You are given a sequence of positive integer values written into a string, separated by spaces. 
 * Write a function that reads these values from given string and calculates their sum. Example:
 * string = "43 68 9 23 318"  result = 461 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumCalculator
{
    static void Main()
    {
        string input = "100 15 1000 10000 1";
        input = input.Trim();
        int sum = 0;
        string[] strNums = input.Split(' ');
        for (int i = 0; i < strNums.Length; i++)
        {
            sum = sum + int.Parse(strNums[i].Trim());
        }
        Console.WriteLine("You were given the numbers {0} as string.",input);
        Console.WriteLine("After calculation, their sum is {0}.", sum);

    }
}
