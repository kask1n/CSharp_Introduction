/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10

Алгоритм решения:
1. Вводим число
2. Создаём массив для хранения остатка от деления на 2
3. В цикле делим на 2, записываем остаток в массив поочерёдно, пока не закончится деление остатка
4. Переворачиваем массив
5. Выводим массив
*/

Console.WriteLine();
int x = 22;
string z = Convert.ToString(x, 2); // Преобразовать число в двоичный код.
Console.WriteLine($"{x} -> {z}");


int GetIntNumber()
{
  int result = 0;

  while (true)
  {
    Console.Write("Введите целое число для преобразования в двоичный тип: ");

    if (int.TryParse(Console.ReadLine(), out result))
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

Console.WriteLine();
int number = GetIntNumber();
string number_str = "";

while (number > 0)
{
  number_str = number_str + number % 2;
  number = number / 2;
}

string result = new string(number_str.Reverse().ToArray());
Console.WriteLine($"-> [{string.Join(", ", result)}]");