// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%2==0 && num!=0) Console.WriteLine("Да");
else Console.WriteLine("Нет");

if(num==0) Console.Write("Все херня, переделывай");
