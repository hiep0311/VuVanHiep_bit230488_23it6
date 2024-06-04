using System;

numbers = []
for i in range(5):
    num = int(input(f"Nhập số thứ {i+1}: "))
    numbers.append(num)

max_num = max(numbers)
min_num = min(numbers)

print(f"Số lớn nhất trong dãy là: {max_num}")
print(f"Số nhỏ nhất trong dãy là: {min_num}")
