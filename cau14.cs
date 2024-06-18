using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Thiết lập encoding để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo số thực x 4 byte
        float x = ReadFloat();

        // In ra giá trị của x
        Console.WriteLine($"Giá trị của x: {x}");
    }

    static float ReadFloat()
    {
        float value;
        while (true)
        {
            Console.Write("Nhập số thực 4 byte: ");
            if (float.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
        }
    }
}