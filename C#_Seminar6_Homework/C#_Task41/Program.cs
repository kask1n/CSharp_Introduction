/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Вводим через один Enter (разбиваем через Split()).
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

string[] GetStringAndFillNewArray()
{
  string[] separators = { ",", " " };

  Console.WriteLine("Введите целые числа через запятую или пробел и нажмите Enter для создания массива:");
  string getString = Console.ReadLine()!;
  Console.WriteLine();

  string[] numbersString = getString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

  return numbersString;
}

int[] ConvertToIntAndFillNewArray(string[] strings)
{
  int count = 0;
  int result;

  for (int i = 0; i < strings.Length; i++)
  {
    if (int.TryParse(strings[i], out result))
      count++;
  }

  int[] numbersInt = new int[count];
  count = 0;

  for (int i = 0; i < strings.Length; i++)
  {
    if (int.TryParse(strings[i], out int number))
    {
      numbersInt[count] = number;
      count++;
    }
  }

  return numbersInt;
}

int CountPositiveNumbers(int[] arr)
{
  int count = 0;
  foreach (var item in arr)
  {
    if (item > 0)
      count++;
  }
  return count;
}

Console.WriteLine();
string[] numStr = GetStringAndFillNewArray();
Console.WriteLine("Исходный массив: [{0}] ->", string.Join(", ", numStr));

int[] numInt = ConvertToIntAndFillNewArray(numStr);
Console.WriteLine("Массив из целых чисел: [{0}] ->", string.Join(", ", numInt));

int countPos = CountPositiveNumbers(numInt);
Console.WriteLine($"Количество положительных чисел в указанном массиве: {countPos}");


// The example displays the following output:

// Введите целые числа через запятую или пробел и нажмите Enter для создания массива:
// 0,1,2,3,4,2.2,-5 -3 -1.1, asdf f23, 222

// Исходный массив: [0, 1, 2, 3, 4, 2.2, -5, -3, -1.1, asdf, f23, 222] ->
// Массив из целых чисел: [0, 1, 2, 3, 4, -5, -3, 222] ->
// Количество положительных чисел в указанном массиве: 5

// Введите целые числа через запятую или пробел и нажмите Enter для создания массива:
// -4 -2 -77   22,,, 2.2 5.5 3,77,4,-5

// Исходный массив: [-4, -2, -77, 22, 2.2, 5.5, 3, 77, 4, -5] ->
// Массив из целых чисел: [-4, -2, -77, 22, 3, 77, 4, -5] ->
// Количество положительных чисел в указанном массиве: 4