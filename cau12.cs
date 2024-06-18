using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Thiết lập encoding để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo số nguyên n 2 byte không dấu
        ushort n = ReadUInt16();

        // In ra giá trị của n
        Console.WriteLine($"Giá trị của n: {n}");

        // Tính tổng bình phương các số từ 1 đến n
        long sum = CalculateSquareSum(n);

        // In ra kết quả
        Console.WriteLine($"Tổng bình phương các số từ 1 đến {n}: {sum}");
    }

    static ushort ReadUInt16()
    {
        ushort value;
        while (true)
        {
            Console.Write("Nhập số nguyên 2 byte không dấu: ");
            if (ushort.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
        }
    }

    static long CalculateSquareSum(ushort n)
    {
        long sum = 0;
        for (ushort i = 1; i <= n; i++)
        {
            sum += i * i;
        }
        return sum;
    }
}
