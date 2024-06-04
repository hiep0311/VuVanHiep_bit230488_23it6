using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        double[] numbers = new double[5];

        Console.WriteLine("Nhập 5 số thực kích thước 8 byte:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Số thứ {i + 1}: ");
            double.TryParse(Console.ReadLine(), out numbers[i]);
        }

        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num;
        }

        double average = sum / numbers.Length;

        Console.WriteLine($"Trung bình cộng của các số trong mảng là: {average}");
    }
}