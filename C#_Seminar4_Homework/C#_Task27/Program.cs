/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetIntNumber()
{
  int result = 0;

  while (true)
  {
    Console.WriteLine("Введите целое число для подсчёта суммы его цифр:");

    if (int.TryParse(Console.ReadLine()!, out result))
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!\n");
    }
  }
  return Math.Abs(result);
}

int GetSumOfDigits(int number)
{
  int sum = 0;

  while (number > 0)
  {
    sum = sum + number % 10;
    number = number / 10;
  }

  return sum;
}

Console.WriteLine();
int number = GetIntNumber();
int sum = GetSumOfDigits(number);
Console.WriteLine($"-> Сумма цифр в числе = {sum}");


// The example displays the following output:

// Введите целое число для подсчёта в нём количества цифр:
// 9,9
// Ввели не число или некорректное число. Повторите ввод!

// Введите целое число для подсчёта в нём количества цифр:
// asdf
// Ввели не число или некорректное число. Повторите ввод!

// Введите целое число для подсчёта в нём количества цифр:
// -1234
// -> Сумма цифр в числе = 10

// Введите целое число для подсчёта в нём количества цифр:
// 1357
// -> Сумма цифр в числе = 16