using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        long[] numbers = new long[5];

        Console.WriteLine("Nhập 5 số nguyên có dấu kích thước 8 byte:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Số thứ {i + 1}: ");
            long.TryParse(Console.ReadLine(), out numbers[i]);
        }

        long sum = 0;
        foreach (long num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"Tổng các số trong mảng là: {sum}");
    }
}