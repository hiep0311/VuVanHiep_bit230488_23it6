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

        double max = numbers[0];
        double min = numbers[0];

        foreach (double num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }

        Console.WriteLine($"Giá trị lớn nhất: {max}");
        Console.WriteLine($"Giá trị nhỏ nhất: {min}");
    }
}