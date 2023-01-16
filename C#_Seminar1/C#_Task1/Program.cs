/*
Задача №1. Напишите программу, которая на вход принимает два числа и проверяет,
является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/

Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine(); // 22 -> "22"
double number1 = Convert.ToInt32(numberStr1); // 22

Console.WriteLine("Введите второе число");
string numberStr2 = Console.ReadLine(); // 22 -> "22"
double number2 = Convert.ToInt32(numberStr2); // 22

double result = number1 / number2;

if (result == number2)
{
  Console.WriteLine($"Число {number1} является квадратом {number2}");
}

else
{
  Console.WriteLine($"Число {number1} НЕ является квадратом {number2}");
}