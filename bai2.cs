using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập số của ngày trong tuần (1-7): ");
        int dayNumber = int.Parse(Console.ReadLine());

        string dayName;

        switch (dayNumber)
        {
            case 1:
                dayName = "Thứ Hai";
                break;
            case 2:
                dayName = "Thứ Ba";
                break;
            case 3:
                dayName = "Thứ Tư";
                break;
            case 4:
                dayName = "Thứ Năm";
                break;
            case 5:
                dayName = "Thứ Sáu";
                break;
            case 6:
                dayName = "Thứ Bảy";
                break;
            case 7:
                dayName = "Chủ Nhật";
                break;
            default:
                dayName = "Không hợp lệ";
                break;
        }

        Console.WriteLine("Ngày này là " + dayName);
    }
}