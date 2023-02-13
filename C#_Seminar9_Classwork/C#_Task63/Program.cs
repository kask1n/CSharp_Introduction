/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

int GetNaturalNumber(string message)
{
  int result = 0;

  while (true)
  {
    Console.Write(message);

    if (int.TryParse(Console.ReadLine(), out result) && result > 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!\n");
    }
  }

  return result;
}

void PrintNumber(int N, int i)
{
  if (i <= N)
  {
    Console.Write($"{i} ");
    i++;
    PrintNumber(N, i);
  }
}

void PrintNumberBetter(int N)
{
  if (N > 0)
  {
    PrintNumberBetter(N - 1);
    Console.Write($"{N} ");
  }
}

Console.WriteLine();
int number = GetNaturalNumber("Введите натуральное число: ");

// int i = 1;
// PrintNumber(number, i);
// Console.WriteLine();

PrintNumberBetter(number);
Console.WriteLine();