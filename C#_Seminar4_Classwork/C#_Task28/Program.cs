/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120

1. Получаем число с консоли
2. Считаем произведение чисел от 1 до введённого числа
3. Выводим произведение на экран
*/

int GetNumber(string message)
{
  int result = 0;

  while (true)
  {
    Console.WriteLine(message);

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

int GetMultiple(int number)
{
  int multiple = 1;

  for (int i = 1; i <= number; i++)
  {
    multiple *= i;
  }
  return multiple;
}

Console.WriteLine();
int number = GetNumber("Введите натуральное число: ");
int resultMultiple = GetMultiple(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {resultMultiple}");