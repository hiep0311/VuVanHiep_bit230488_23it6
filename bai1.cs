using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Enter a number: ");
        double num = double.Parse(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (num < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}
