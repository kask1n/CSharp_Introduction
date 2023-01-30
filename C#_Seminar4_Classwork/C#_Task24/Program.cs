/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36

1. Получаем число с консоли
2. Считаем сумму чисел от 1 до введённого числа
3. Выводим сумму на экран
*/

int GetNumber(string message)
{
  int result = 0;
  
  while (true)
  {
    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out result) && result > 1)
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

int GetSumm(int number)
{
  int sum = 0;

  for (int i = 1; i <= number; i++)
  {
    sum += i;
  }
  return sum;
}

Console.WriteLine();
int number = GetNumber("Введите число больше 1: ");
int sum = GetSumm(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");