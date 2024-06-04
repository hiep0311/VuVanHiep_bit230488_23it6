using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int number;
        int sum = 0;

        Console.WriteLine("Nhập một chuỗi các số. Nhập 0 để kết thúc.");

        while (true)
        {
            Console.Write("Nhập số: ");
            number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }
            else if (number < 0)
            {
                Console.WriteLine("Số âm sẽ bị bỏ qua.");
                continue;
            }
            else
            {
                sum += number;
            }
        }

        Console.WriteLine("Tổng của các số dương: " + sum);
    }
}