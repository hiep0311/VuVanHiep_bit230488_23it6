using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        byte n;
        Console.Write("Nhập số nguyên n: ");
        n = byte.Parse(Console.ReadLine());

        uint total = (uint)n * (n + 1) / 2;
        Console.WriteLine($"Tổng các số từ 1 đến {n} là: {total}");
    }
}