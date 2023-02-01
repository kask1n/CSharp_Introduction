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
  Console.Write("[{0}]", string.Join(", ", numbersString));

  return numbersString;
}

int[] ConvertToIntAndFillNewIntArray(string[] strings)
{
  int count = 0;

  for (int i = 0; i < strings.Length; i++)
  {
    if (int.TryParse(strings[i], out int result))
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

Console.WriteLine();
string[] numStr = GetStringWithNumbersAndFillNewStringArrayAndPrint();
int[] numInt = ConvertToIntAndFillNewIntArray(numStr);
Console.WriteLine(" -> [{0}]", string.Join(", ", numInt));


// The example displays the following output:

// Введите целые числа через запятую или пробел и нажмите Enter для создания массива:
// -100,0,444,5.5,asdf,ads,,,hg,2,1,3,

// [-100, 0, 444, 5.5, asdf, ads, hg, 2, 1, 3] -> [-100, 0, 444, 2, 1, 3]

// Введите целые числа через запятую или пробел и нажмите Enter для создания массива:
// as dfs 1 23 4  6    af a sdf ,,,2,2,4,,2.2..2      1   -1223   1-1  -1

// [as, dfs, 1, 23, 4, 6, af, a, sdf, 2, 2, 4, 2.2..2, 1, -1223, 1-1, -1] -> [1, 23, 4, 6, 2, 2, 4, 1, -1223, -1]