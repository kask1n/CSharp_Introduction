/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int GetNaturalNumber(string message)
{
  int result = 0;

  while (true)
  {
    Console.Write(message);

    if (int.TryParse(Console.ReadLine(), out result) && result > 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!");
    }
  }

  return result;
}

int[,,] InitAndFill3DArrayWithUniqueValues(int rows, int columns, int layers, int rndMin, int rndMax)
{
  int[,,] matrix = new int[rows, columns, layers];
  Random rnd = new Random();
  int temp;
  Dictionary<int, bool> uniqueValues = new Dictionary<int, bool>();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      for (int k = 0; k < layers; k++)
      {
        temp = rnd.Next(rndMin, rndMax);

        if (uniqueValues.ContainsKey(temp))
        {
          k--;
          continue;
        }
        else
        {
          uniqueValues.Add(temp, true);
          matrix[i, j, k] = temp;
        }
      }
    }
  }

  return matrix;
}

void PrintMatrix(int[,,] matrix)
{
  for (int k = 0; k < matrix.GetLength(2); k++)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        Console.Write($"{matrix[i, j, k],7} ({i},{j},{k})");
      }

      Console.WriteLine();
    }

    Console.WriteLine();
  }
}

Console.WriteLine();
int countOfRows = GetNaturalNumber("Введите количество строк: ");
int countOfColumns = GetNaturalNumber("Введите количество столбцов: ");
int countOfLayers = GetNaturalNumber("Введите количество слоёв: ");

int rndMin = 10;
int rndMax = 100; // Аргументы для Random.Next[rndMin; rndMax) - все двузначные числа.

if (rndMax - rndMin < countOfRows * countOfColumns * countOfLayers) // Проверка выполнимости метода.
{
  Console.WriteLine("\n-> Матрица указанных размеров не может быть заполнена " +
                    "неповторяющимися целыми двухзначными числами.");
}

else
{
  Console.WriteLine("\n->");
  int[,,] cubeMatrix = InitAndFill3DArrayWithUniqueValues(countOfRows, countOfColumns, countOfLayers, rndMin, rndMax);
  Console.WriteLine();
  PrintMatrix(cubeMatrix);
}


// The example displays the following output:

// Введите количество строк: 2
// Введите количество столбцов: 3
// Введите количество слоёв: 4

// ->

//      58 (0,0,0)     99 (0,1,0)     53 (0,2,0)
//      49 (1,0,0)     84 (1,1,0)     88 (1,2,0)

//      45 (0,0,1)     55 (0,1,1)     62 (0,2,1)
//      36 (1,0,1)     71 (1,1,1)     44 (1,2,1)

//      13 (0,0,2)     91 (0,1,2)     31 (0,2,2)
//      95 (1,0,2)     23 (1,1,2)     60 (1,2,2)

//      90 (0,0,3)     32 (0,1,3)     57 (0,2,3)
//      43 (1,0,3)     15 (1,1,3)     67 (1,2,3)

// ---------------------------------------------

// Введите количество строк: 5
// Введите количество столбцов: 5
// Введите количество слоёв: 5

// -> Матрица указанных размеров не может быть заполнена неповторяющимися целыми двухзначными числами.