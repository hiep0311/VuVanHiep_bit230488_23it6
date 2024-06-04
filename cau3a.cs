using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        ushort[] numbers = new ushort[5];

        Console.WriteLine("Nhập 5 số nguyên không dấu kích thước 2 byte:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Số thứ {i + 1}: ");
            numbers[i] = ushort.Parse(Console.ReadLine());
        }

        ushort sum = 0;
        foreach (ushort num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"Tổng các số trong mảng là: {sum}");
    }
}