﻿/*
Задача 2: Напишите программу, которая на вход принимает два числа
и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine(); // 22 -> "22"
int number = Convert.ToInt32(numberStr); // 22
int result = number % 10;
Console.WriteLine($"Последней цифрой числа {number} является цифра {result}");