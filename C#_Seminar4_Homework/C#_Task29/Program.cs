/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

string[] GetStringWithNumbersAndFillNewStringArrayAndPrint()
{
  string[] separators = { ",", " " };

  Console.WriteLine("Введите целые числа через запятую или пробел и нажмите Enter для создания массива:");
  string getString = Console.ReadLine()!;
  Console.WriteLine();

  string[] numbersString = getString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

  foreach (string number in numbersString)
    Console.Write($"{number}; ");

  return numbersString;
}

int[] ConvertToIntAndFillNewIntArray(string[] strings)
{
  int[] numbersInt = new int[strings.Length];
  int count = 0;

  for (int i = 0; i < strings.Length; i++)
  {
    if (int.TryParse(strings[i], out int number))
    {
      numbersInt[count] = number;
      count++;
    }
  }

  // Дописать команду для очистки массива от пустых значений..
  return numbersInt;
}

Console.WriteLine();
string[] numStr = GetStringWithNumbersAndFillNewStringArrayAndPrint();
int[] numInt = ConvertToIntAndFillNewIntArray(numStr);

Console.WriteLine($"-> [{string.Join(", ", numInt)}]");


// The example displays the following output:

// Введите целые числа через запятую или пробел и нажмите Enter для создания массива:
// -100, 0,   1234,3,-5

// -100; 0; 1234; 3; -5; -> [-100, 0, 1234, 3, -5]

// Введите целые числа через запятую или пробел и нажмите Enter для создания массива:
// 1,0,-5

// 1; 0; -5; -> [1, 0, -5]