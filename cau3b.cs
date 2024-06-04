using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        short[] numbers = new short[5];

        Console.WriteLine("Nhập 5 số nguyên có dấu kích thước 2 byte:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Số thứ {i + 1}: ");
            numbers[i] = short.Parse(Console.ReadLine());
        }

        short sum = 0;
        foreach (short num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"Tổng các số trong mảng là: {sum}");
    }
}