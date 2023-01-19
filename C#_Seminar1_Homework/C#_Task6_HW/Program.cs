/*
Задача 6: Напишите программу, которая на вход принимает число
и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine();
Console.Write("Проверка на чётность. Введите число: ");
string numberStr = Console.ReadLine(); // 22 -> "22"
double number = Convert.ToDouble(numberStr); // 22
Console.WriteLine();

if (number % 2 ==0)
{
  Console.WriteLine($"-> Да");
}
else
{
  Console.WriteLine($"-> Нет");
}