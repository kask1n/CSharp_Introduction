/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int GetDigitFromUser()
{
  int result = 0;
  Console.WriteLine();
  Console.WriteLine("Введите цифру, обозначающую день недели:");
  Console.WriteLine();

  while (true)
  {
    if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 8)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не цифру или некорректную цифру. Повторите ввод!");
      Console.WriteLine();
    }
  }
  return result;
}

int digit = GetDigitFromUser();

if (digit < 6)
{
  Console.WriteLine($"-> Нет, не является выходным.");
}
else
{
  Console.WriteLine($"-> Да, выходной.");
}