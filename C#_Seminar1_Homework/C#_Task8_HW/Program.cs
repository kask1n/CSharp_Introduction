/*
Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine();
Console.WriteLine("Программа для отображения всех чётных чисел от 1 до N.");
Console.Write("Введите число: ");
string numberStr = Console.ReadLine(); // 22 -> "22"
int number = Convert.ToInt32(numberStr); // 22
Console.WriteLine();

if (number > 1)
{
  for (int i = 2; i <= number; i = i + 2)
  {
    if (i < number - 1)
    {
      Console.Write(i + ", ");
    }
    else
    {
      Console.Write(i);
    }
  }
}
else if (number < 1)
{
  for (int i = 0; i >= number; i = i - 2)
  {
    if (i > number + 1)
    {
      Console.Write(i + ", ");
    }
    else
    {
      Console.Write(i);
    }
  }
}
else
{
  Console.WriteLine("В указанном диапазоне отсутствуют чётные числа.");
}

Console.WriteLine();