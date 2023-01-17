/*
Задача 6: Напишите программу, которая на вход принимает число
и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine(); // 22 -> "22"
int number = Convert.ToInt32(numberStr); // 22
int result = number % 10;
Console.WriteLine($"Последней цифрой числа {number} является цифра {result}");