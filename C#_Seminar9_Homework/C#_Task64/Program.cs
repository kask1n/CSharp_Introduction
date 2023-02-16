/*
Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNaturalNumber(string message)
{
  int result;

  while (true)
  {
    Console.Write(message);

    if (int.TryParse(Console.ReadLine()!, out result) && result > 0)
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

void PrintNumberRec(int N)
{
  if (N > 1)
  {
    Console.Write($"{N}, ");
    PrintNumberRec(N - 1);
  }

  if (N == 1)
  {
    Console.Write($"{N}");
    PrintNumberRec(N - 1);
  }
}

Console.WriteLine();
int number = GetNaturalNumber("Введите натуральное число N: ");
Console.WriteLine();

Console.Write("Все натуральные числа от N до 1:\n-> ");
PrintNumberRec(number);
Console.WriteLine();


// The example displays the following output:

// Введите натуральное число N: 7

// Все натуральные числа от N до 1:
// -> 7, 6, 5, 4, 3, 2, 1