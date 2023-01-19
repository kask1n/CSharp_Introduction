/*
Задача 2: Напишите программу, которая на вход принимает два числа
и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число: ");
string aStr = Console.ReadLine(); // 22 -> "22"
double a = Convert.ToDouble(aStr); // 22

Console.Write("Введите второе число: ");
string bStr = Console.ReadLine(); // 22 -> "22"
double b = Convert.ToDouble(bStr); // 22

Console.WriteLine();

if (a > b)
{
  Console.WriteLine($"-> max = {a}");
}
else if (a == b)
{
  Console.WriteLine($"-> Числа равны, max = {a}");
}
else
{
  Console.WriteLine($"-> max = {b}");
}