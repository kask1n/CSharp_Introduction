/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int GetNaturalNumber()
{
  int naturalNumber = 0;

  while (true)
  {
    Console.Write("Введите натуральное число: ");

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

int[] Fibonacci(int n)
{
  int[] arr = new int[n];

  if (n == 1)
    return new int[1] { 0 };

  arr[0] = 0;
  arr[1] = 1;

  for (int i = 2; i < n; i++)
  {
    arr[i] = arr[i - 1] + arr[i - 2];
  }
  return arr;
}

Console.WriteLine();
int N = GetNaturalNumber();
int[] array = Fibonacci(N);
Console.WriteLine($"-> [{string.Join(", ", array)}]");