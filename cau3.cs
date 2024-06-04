using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int n, factorial = 1;

        Console.Write("Nhập một số nguyên dương: ");
        n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương.");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Giai thừa của {0} là: {1}", n, factorial);
        }
    }
}