/*
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1, 4
*/

int GetNumber() // Функция, принимающая число (в т.ч. отрицательное).
{
  Console.Write("Введите число: ");
  int number = Convert.ToInt32(Console.ReadLine());
  number = Math.Abs(number);
  return number;
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