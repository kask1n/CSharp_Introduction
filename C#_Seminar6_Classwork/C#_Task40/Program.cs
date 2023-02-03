/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины.

Алгоритм решения:
1. Инициализируем массив
2. Печатаем массив
3. Переворачиваем массив
4*. Попробуем решить всё в одну строчку
*/

double GetAnyNumber(int n)
{
  double anyNumber = 0;

  while (true)
  {
    Console.Write($"Введите число {n}: ");

    if (double.TryParse(Console.ReadLine()!, out anyNumber))
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число. Повторите ввод!\n");
    }
  }
  return anyNumber;
}

Console.WriteLine();
double number1 = GetAnyNumber(1);
double number2 = GetAnyNumber(2);
double number3 = GetAnyNumber(3);

if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2)
{
  Console.WriteLine("-> Треугольник существует!");
}
else
  Console.WriteLine("-> Треугольник НЕ существует!");