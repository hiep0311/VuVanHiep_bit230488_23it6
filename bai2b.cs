using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        sbyte[] numbers = new sbyte[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Nhập số thứ {i + 1}: ");
            numbers[i] = sbyte.Parse(Console.ReadLine());
        }

        sbyte evenSum = 0;
        foreach (sbyte num in numbers)
        {
            if (num % 2 == 0)
                evenSum += num;
        }

        Console.WriteLine($"Tổng các số chẵn trong dãy là: {evenSum}");
    }
}