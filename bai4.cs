using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int rows, cols;

        Console.Write("Nhập số hàng: ");
        rows = int.Parse(Console.ReadLine());

        Console.Write("Nhập số cột: ");
        cols = int.Parse(Console.ReadLine());

        Console.WriteLine("Mẫu ký tự sao (*):");

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= cols; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}