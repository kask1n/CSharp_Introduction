/*
Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

int GetNumber()
{
  Console.WriteLine("Введите число");
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

int num1 = GetNumber();
int num2 = GetNumber();

if (num1 == num2 * num2 || num2 == num1 * num1)
{
  Console.WriteLine($"{num1}, {num2} -> Да");
}
else
{
  Console.WriteLine($"{num1}, {num2} -> Нет");
}