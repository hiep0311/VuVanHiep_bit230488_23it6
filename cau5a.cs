using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        float[] numbers = new float[5];

        Console.WriteLine("Nhập 5 số thực kích thước 4 byte:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Số thứ {i + 1}: ");
            float.TryParse(Console.ReadLine(), out numbers[i]);
        }

        float max = numbers[0];
        float min = numbers[0];

        foreach (float num in numbers)
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