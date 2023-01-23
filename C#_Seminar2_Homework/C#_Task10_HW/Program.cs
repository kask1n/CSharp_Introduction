/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine();

int GetNumber() // Функция, принимающая трёхзначное число (в т.ч. отрицательное), с проверкой.
{
  Console.Write("Введите трёхзначное число: ");
  int number = Convert.ToInt32(Console.ReadLine());
  number = Math.Abs(number);
  if (number > 99 && number < 1000)
  {
    return number;
  }
  else
  {
    return -1;
  }
}

int ShowSecondDigit(int abc) // Функция, возвращающая вторую цифру в трёхзначном числе.
{
  return (abc - abc / 100 * 100) / 10;
}

int num = GetNumber();
if (num == -1)
{
  Console.WriteLine("-> Ошибка. Число не является трёхзначным. Программа остановлена.");
}
else
{
  int result = ShowSecondDigit(num);
  Console.WriteLine($"-> Вторая цифра введённого числа: {result}");
}