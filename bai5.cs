using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random rand = new Random();
        int secretNumber = rand.Next(1, 101);
        int guess;

        Console.WriteLine("Đoán một số bí mật từ 1 đến 100.");

        while (true)
        {
            Console.Write("Nhập số của bạn: ");
            guess = int.Parse(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("Chúc mừng! Bạn đã đoán đúng.");
                break;
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Số của bạn quá thấp. Hãy thử lại.");
            }
            else
            {
                Console.WriteLine("Số của bạn quá cao. Hãy thử lại.");
            }
        }
    }
}