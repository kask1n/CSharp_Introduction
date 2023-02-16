/*
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int SumNaturalNumbersRec(int m, int n) // [m, n]
{
  if (m < n) return m + SumNaturalNumbersRec(++m, n);
  if (m > n) return m + SumNaturalNumbersRec(--m, n);
  else return m;
}

Console.WriteLine();
int numberM = GetNaturalNumber("Введите натуральное число M: ");
int numberN = GetNaturalNumber("Введите натуральное число N: ");

Console.Write("\n-> Сумма всех натуральных чисел в промежутке [M, N] = " +
             $"{SumNaturalNumbersRec(numberM, numberN)}\n");


// The example displays the following output:

// Введите натуральное число M: 1
// Введите натуральное число N: 5

// -> Сумма всех натуральных чисел в промежутке [M, N] = 15

// --------------------------------------------------------

// Введите натуральное число M: 5
// Введите натуральное число N: 1

// -> Сумма всех натуральных чисел в промежутке [M, N] = 15

// --------------------------------------------------------

// Введите натуральное число M: 5
// Введите натуральное число N: 5

// -> Сумма всех натуральных чисел в промежутке [M, N] = 5