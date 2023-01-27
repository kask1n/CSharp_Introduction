/*
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1, 4
*/

int GetNumber()
{
  Console.WriteLine();
  int result = 0;

  while (true)
  {
    Console.WriteLine("Введите натуральное число:");

    if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
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

int num = GetNumber();

for (int i = 1; i <= num; i++)
{
  if (i < num)
  {
    Console.Write($"{i * i}, ");
  }
  else
  {
    Console.Write(i * i);
  }
}