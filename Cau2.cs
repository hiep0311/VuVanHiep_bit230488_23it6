Console.Write("Nhập số thực: ");
string input = Console.ReadLine();
double number = double.Parse(input);

int int_number = (int)number;
long long_number = (long)number;

Console.WriteLine($"Số bạn đã nhập là {number}, số nguyên là {int_number} và số dài là {long_number}.");