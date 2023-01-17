/*
Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine(); // 22 -> "22"
int number = Convert.ToInt32(numberStr); // 22
int result = number % 10;
Console.WriteLine($"Последней цифрой числа {number} является цифра {result}");