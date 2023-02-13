/*
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

string PrintNumber(int m, int n)
{
  if (m < n)
    return $"{m}, " + PrintNumber(m + 1, n);
  else
    return String.Empty;
}

Console.WriteLine();
int numberM = GetNaturalNumber("Введите натуральное число M: ");
int numberN = GetNaturalNumber("Введите натуральное число N: ");
Console.WriteLine();

Console.WriteLine($"-> " + PrintNumber(numberM, numberN) + numberN);