using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        ulong number;

        Console.Write("Nhập một số nguyên không dấu kích thước 8 byte: ");
        ulong.TryParse(Console.ReadLine(), out number);

        if (IsPalindrome(number))
        {
            Console.WriteLine($"{number} là số Palindrome.");
        }
        else
        {
            Console.WriteLine($"{number} không phải là số Palindrome.");
        }
    }

    static bool IsPalindrome(ulong n)
    {
        ulong originalNumber = n;
        ulong reversedNumber = 0;

        while (n > 0)
        {
            reversedNumber = reversedNumber * 10 + (n % 10);
            n /= 10;
        }

        return originalNumber == reversedNumber;
    }
}