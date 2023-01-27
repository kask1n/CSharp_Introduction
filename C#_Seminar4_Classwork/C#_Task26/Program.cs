/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5

1. Получаем число с консоли
2. Считаем количество цифр в числе
3. Выводим на экран
*/

int GetNumber(string message)
{
  Console.WriteLine(message);
  int result = 0;

  while (true)
  {
    if (int.TryParse(Console.ReadLine(), out result))
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число. Повторите ввод!");
    }
  }
  return result;
}

// int GetSumm(int number)
// {
//   int sum = 0;
//   for (int i = 1; i <= number; i++)
//   {
//     sum += i;
//   }
//   return sum;
// }

int number = GetNumber("Введите число больше 1: ");
// int sum = GetSumm(number);
Console.WriteLine(number);