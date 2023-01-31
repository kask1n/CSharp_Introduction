/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double GetAnyNumber()
{
  double anyNumber = 0;

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
  int naturalNumber = 0;

  while (true)
  {
    Console.Write("Введите степень (натуральное число): ");

    if (int.TryParse(Console.ReadLine()!, out naturalNumber) && naturalNumber > 0)
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

Console.WriteLine();
var any = GetAnyNumber();
Console.WriteLine("-> ОК!\n");

var natural = GetNaturalNumber();
Console.WriteLine("-> ОК!\n");

var powerNumber = Math.Pow(any, natural);
Console.WriteLine($"-> Число {any} в степени {natural} равняется {powerNumber}.");


// The example displays the following output:

// Введите любое число для возведения в степень: qwer
// Ввели не число. Повторите ввод!

// Введите любое число для возведения в степень: -9,99
// -> ОК!

// Введите степень (натуральное число): -3
// Ввели не число или некорректное число. Повторите ввод!

// Введите степень (натуральное число): 0
// Ввели не число или некорректное число. Повторите ввод!

// Введите степень (натуральное число): 1,1
// Ввели не число или некорректное число. Повторите ввод!

// Введите степень (натуральное число): asdf
// Ввели не число или некорректное число. Повторите ввод!

// Введите степень (натуральное число): 2
// -> ОК!

// -> Число -9,99 в степени 2 равняется 99,8001.