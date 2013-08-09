/*Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.*/

using System;

class TriangleArea
{
    static void Main()
    {
        Console.WriteLine("How you want to calculate the area of triangle?\n");
        Console.WriteLine("1. By side and altitude.\n2. By three sides\n3. Two sides and an angle between them.");
        Console.WriteLine("Please, enter 1, 2 or 3 in order to select one of the options");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: SideAndAltitude();
                break;
            case 2: ThreeSides();
                break;
            case 3: TwoSidesAndAngle();
                break;
            default: Console.WriteLine("Enter correct number!");
                break;
        }
    }

    private static void SideAndAltitude()
    {
        Console.WriteLine();
        Console.WriteLine("You have selected an option to calculate the S through one side and Altitude.");
        Console.WriteLine("Enter a side:");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a altitude:");
        double altitude = double.Parse(Console.ReadLine());
        Console.WriteLine("S = {0}", side * altitude / 2);
    }

    private static void ThreeSides()
    {
        Console.WriteLine();
        Console.WriteLine("You have selected an option to calculate the S through three sides. Good Job!");
        Console.WriteLine("Enter a first side:");
        double sideOne = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second side:");
        double sideTwo = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a third side:");
        double sideThree = double.Parse(Console.ReadLine());
        double s = (sideOne + sideTwo + sideThree) / 2;
        Console.WriteLine("S = {0}", Math.Sqrt(s * (s - sideOne) * (s - sideTwo) * (s - sideThree)));
    }

    private static void TwoSidesAndAngle()
    {
        Console.WriteLine();
        Console.WriteLine("You have selected an option to calculate the S through two sides and an angle. Carry on:");
        Console.WriteLine("Enter a first side:");
        double sideOne = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second side:");
        double sideTwo = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter an angle:");
        double angle = double.Parse(Console.ReadLine());
        Console.WriteLine("S = {0}", sideOne * sideTwo * Math.Sin(Math.PI * angle / 180) / 2);
    }
       

}
