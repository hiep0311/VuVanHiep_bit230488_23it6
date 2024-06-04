using System;
using System.Text;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //
            uint number;

            while (true)
            {
                try
                {
                    Console.Write("Nhập một số nguyên không dấu (4 byte): ");
                    number = uint.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập số nguyên không dấu hợp lệ.");
                }
            }

            uint reversedNumber = 0;
            while (number > 0)
            {
                reversedNumber = reversedNumber * 10 + (number % 10);
                number /= 10;
            }

            Console.WriteLine("Số đảo ngược: {0}", reversedNumber);
        }
    }
}
