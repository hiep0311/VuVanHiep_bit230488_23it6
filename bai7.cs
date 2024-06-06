using System;
using System.Text;

namespace BaiTapLuyenTapKieuSoC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //
            Console.WriteLine("Chọn bài tập (a, b, c, d, e, g, h, k, l, m):");
            char option = char.Parse(Console.ReadLine());

            switch (option)
            {
                case 'a':
                    // Bài a
                    Console.Write("Nhập số nguyên không dấu thứ nhất: ");
                    uint num1 = uint.Parse(Console.ReadLine());
                    Console.Write("Nhập số nguyên không dấu thứ hai: ");
                    uint num2 = uint.Parse(Console.ReadLine());
                    uint sum = num1 + num2;
                    Console.WriteLine($"Tổng của {num1} và {num2} là: {sum}");
                    break;

                case 'b':
                    // Bài b
                    Console.Write("Nhập chiều dài hình chữ nhật (số nguyên 2 byte không dấu): ");
                    ushort length = ushort.Parse(Console.ReadLine());
                    Console.Write("Nhập chiều rộng hình chữ nhật (số nguyên 2 byte không dấu): ");
                    ushort width = ushort.Parse(Console.ReadLine());
                    uint area = (uint)length * (uint)width;
                    uint perimeter = 2 * ((uint)length + (uint)width);
                    Console.WriteLine($"Diện tích hình chữ nhật là: {area}");
                    Console.WriteLine($"Chu vi hình chữ nhật là: {perimeter}");
                    break;

                case 'c':
                    // Bài c
                    Console.Write("Nhập số nguyên không dấu 4 byte: ");
                    uint number = uint.Parse(Console.ReadLine());
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"{number} là số chẵn");
                    }
                    else
                    {
                        Console.WriteLine($"{number} là số lẻ");
                    }
                    break;

                case 'd':
                    // Bài d
                    Console.Write("Nhập số nguyên có dấu 1 byte thứ nhất: ");
                    sbyte s1 = sbyte.Parse(Console.ReadLine());
                    Console.Write("Nhập số nguyên có dấu 1 byte thứ hai: ");
                    sbyte s2 = sbyte.Parse(Console.ReadLine());
                    sbyte sum_d = (sbyte)(s1 + s2);
                    Console.WriteLine($"Tổng của {s1} và {s2} là: {sum_d}");
                    break;

                case 'e':
                    // Bài e
                    Console.Write("Nhập số nguyên không dấu 4 byte: ");
                    uint n = uint.Parse(Console.ReadLine());
                    uint sum_e = (n * (n + 1)) / 2;
                    Console.WriteLine($"Tổng của các số từ 1 đến {n} là: {sum_e}");
                    break;

                case 'g':
                    // Bài g
                    Console.Write("Nhập chiều dài hình chữ nhật (số thực 8 byte): ");
                    double length_g = double.Parse(Console.ReadLine());
                    Console.Write("Nhập chiều rộng hình chữ nhật (số thực 8 byte): ");
                    double width_g = double.Parse(Console.ReadLine());
                    double area_g = length_g * width_g;
                    double perimeter_g = 2 * (length_g + width_g);
                    Console.WriteLine($"Diện tích hình chữ nhật là: {area_g}");
                    Console.WriteLine($"Chu vi hình chữ nhật là: {perimeter_g}");
                    break;

                case 'h':
                    // Bài h
                    Console.Write("Nhập số nguyên thứ nhất: ");
                    int num_h1 = int.Parse(Console.ReadLine());
                    Console.Write("Nhập số nguyên thứ hai: ");
                    int num_h2 = int.Parse(Console.ReadLine());
                    Console.Write("Nhập số nguyên thứ ba: ");
                    int num_h3 = int.Parse(Console.ReadLine());
                    int max = Math.Max(Math.Max(num_h1, num_h2), num_h3);
                    Console.WriteLine($"Số lớn nhất trong ba số là: {max}");
                    break;

                case 'k':
                    // Bài k
                    Console.Write("Nhập số nguyên không âm: ");
                    uint n_k = uint.Parse(Console.ReadLine());
                    uint factorial = 1;
                    for (uint i = 1; i <= n_k; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"Giai thừa của {n_k} là: {factorial}");
                    break;

                case 'l':
                    // Bài l
                    Console.Write("Nhập số nguyên không âm: ");
                    uint n_l = uint.Parse(Console.ReadLine());
                    bool isPrime = true;
                    if (n_l <= 1)
                    {
                        isPrime = false;
                    }
                    else
                    {
                        for (uint i = 2; i <= Math.Sqrt(n_l); i++)
                        {
                            if (n_l % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine($"{n_l} là số nguyên tố");
                    }
                    else
                    {
                        Console.WriteLine($"{n_l} không phải là số nguyên tố");
                    }
                    break;

                case 'm':
                    // Bài m
                    Console.Write("Nhập số nguyên: ");
                    int n_m = int.Parse(Console.ReadLine());
                    int sum_m = 0;
                    for (int i = 1; i < n_m; i++)
                    {
                        if (n_m % i == 0)
                        {
                            sum_m += i;
                        }
                    }
                    if (sum_m == n_m)
                    {
                        Console.WriteLine($"{n_m} là số hoàn hảo");
                    }
                    else
                    {
                        Console.WriteLine($"{n_m} không phải là số hoàn hảo");
                    }
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}