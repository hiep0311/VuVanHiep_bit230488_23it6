using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Thiết lập encoding để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo số nguyên n 1 byte không dấu
        byte n = ReadByte();

        // In ra giá trị của n
        Console.WriteLine($"Giá trị của n: {n}");
    }

    static byte ReadByte()
    {
        byte value;
        while (true)
        {
            Console.Write("Nhập số nguyên 1 byte không dấu (trong khoảng 2 đến 10): ");
            if (byte.TryParse(Console.ReadLine(), out value) && value >= 2 && value <= 10)
                return value;
            Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
        }
    }
}
