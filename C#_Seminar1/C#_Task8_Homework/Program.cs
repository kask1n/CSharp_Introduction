/*
Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine(); // 22 -> "22"
int number = Convert.ToInt32(numberStr); // 22
int result = number % 10;
Console.WriteLine($"Последней цифрой числа {number} является цифра {result}");