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

        sbyte maxNum = numbers[0];
        sbyte minNum = numbers[0];

        foreach (sbyte num in numbers)
        {
            if (num > maxNum)
                maxNum = num;
            if (num < minNum)
                minNum = num;
        }

        Console.WriteLine($"Số lớn nhất trong dãy là: {maxNum}");
        Console.WriteLine($"Số nhỏ nhất trong dãy là: {minNum}");
    }
}