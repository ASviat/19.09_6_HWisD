//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
//  22 3 9 -> 22

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int Max=num1;
if (Max<num2) Max=num2;
if (Max<num3) Max=num3;

Console.WriteLine($"Max = {Max}");