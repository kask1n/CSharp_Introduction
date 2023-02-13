/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

double GetAnyNumber()
{
  double anyNumber;

  while (true)
  {
    Console.Write("Введите любое число для возведения в степень: ");

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

int GetNaturalNumberOrZero()
{
  int naturalNumber;

  while (true)
  {
    Console.Write("Введите степень (натуральное число или ноль): ");

    if (int.TryParse(Console.ReadLine()!, out naturalNumber) && naturalNumber >= 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!\n");
    }
  }
  return naturalNumber;
}

double PowerNumber(double anyNumber, int power)
{
  if (power == 0)
    return 1;
  else if (power % 2 == 0)
    return PowerNumber(anyNumber * anyNumber, power / 2); // Для уменьшения сложности вычислений.
  else
    return anyNumber * PowerNumber(anyNumber, power - 1);
}

Console.WriteLine();
var any = GetAnyNumber();
Console.WriteLine("-> ОК!\n");

var natural = GetNaturalNumberOrZero();
Console.WriteLine("-> ОК!\n");

Console.WriteLine($"-> Число {any} в степени {natural} равняется {PowerNumber(any, natural):f2}.");