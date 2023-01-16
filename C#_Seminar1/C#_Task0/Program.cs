/*
Задача №0. Напишите программу, которая на вход принимает число и выдаёт его квадрат
(число, умноженное на само себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine(); // 22 -> "22"
int number = Convert.ToInt32(numberStr); // 22

int result = number * number;

Console.WriteLine($"Квадрат числа {number} = {result}");
Console.WriteLine("Квадрат числа " + number + " = " + result);
Console.WriteLine("Квадрат числа {0} = {1}", number, result);
Console.WriteLine("Квадрат числа {number} = {result}");