/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
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

int GetNaturalNumber()
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

var natural = GetNaturalNumber();
Console.WriteLine("-> ОК!\n");

Console.WriteLine($"-> Число {any} в степени {natural} равняется {PowerNumber(any, natural):f2}.");