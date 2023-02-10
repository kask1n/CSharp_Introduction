/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int GetIntNumber()
{
  int result;

  while (true)
  {
    Console.WriteLine("Введите целое число для вычисления суммы его цифр: ");

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

int FindSumOfDigits(int number)
{
  if (number != 0)
    return number % 10 + FindSumOfDigits(number / 10);
  else
    return number;
}

Console.WriteLine();
int number = GetIntNumber();
Console.WriteLine();

int sum = FindSumOfDigits(number);
Console.WriteLine($"-> Сумма цифр указанного числа = {sum}");