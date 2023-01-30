/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5

1. Получаем число с консоли
2. Считаем количество цифр в числе
3. Выводим на экран
*/

int GetNumber(string message)
{
  int result = 0;

  while (true)
  {
    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out result))
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!\n");
    }
  }
  return Math.Abs(result);
}

void GetLongAndPrint(int number)
{
  string text = number.ToString();
  int longText = text.Length;
  Console.WriteLine(longText);
}

Console.WriteLine();
int number = GetNumber("Введите целое число: ");
GetLongAndPrint(number);