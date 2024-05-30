using System;

namespace StringManipulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập một chuỗi:");
            string userInput = Console.ReadLine();

            // Đảo ngược chuỗi
            string reversedString = ReverseString(userInput);
            Console.WriteLine($"Chuỗi đảo ngược: {reversedString}");

            // Đếm số lần xuất hiện của một chuỗi con
            Console.WriteLine("Nhập chuỗi con cần tìm kiếm:");
            string searchString = Console.ReadLine();
            int occurrences = CountOccurrences(userInput, searchString);
            Console.WriteLine($"Số lần xuất hiện của '{searchString}' trong '{userInput}': {occurrences}");

            // Thay thế chuỗi con
            Console.WriteLine("Nhập chuỗi con cần thay thế:");
            string oldSubstring = Console.ReadLine();
            Console.WriteLine("Nhập chuỗi con mới:");
            string newSubstring = Console.ReadLine();
            string modifiedString = ReplaceSubstring(userInput, oldSubstring, newSubstring);
            Console.WriteLine($"Chuỗi sau khi thay thế: {modifiedString}");

            // Xóa khoảng trắng
            string stringWithoutWhitespace = RemoveWhitespace(userInput);
            Console.WriteLine($"Chuỗi không có khoảng trắng: {stringWithoutWhitespace}");
        }

        static string ReverseString(string inputString)
        {
            return new string(inputString.ToCharArray().Reverse().ToArray());
        }

        static int CountOccurrences(string inputString, string searchString)
        {
            return inputString.Split(new[] { searchString }, StringSplitOptions.None).Length - 1;
        }

        static string ReplaceSubstring(string inputString, string oldSubstring, string newSubstring)
        {
            return inputString.Replace(oldSubstring, newSubstring);
        }

        static string RemoveWhitespace(string inputString)
        {
            return inputString.Replace(" ", "");
        }
    }
}
