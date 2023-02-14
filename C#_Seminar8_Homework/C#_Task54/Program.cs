/*
Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int[,] InitAndFill2DArray(int rows, int columns)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = rnd.Next(0, 10); // [0; 10)
    }
  }

  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],5}");
    }
    Console.WriteLine();
  }
}

void SelectionSortReverse(int[,] array)
{
  for (int row = 0; row < array.GetLength(0); row++)
  {
    for (int i = 0; i < array.GetLength(1) - 1; i++)
    {
      int maxPosition = i;

      for (int j = i + 1; j < array.GetLength(1); j++)
      {
        if (array[row, j] > array[row, maxPosition]) maxPosition = j;
      }

      int temporary = array[row, i];
      array[row, i] = array[row, maxPosition];
      array[row, maxPosition] = temporary;
    }
  }
}

Console.WriteLine();
int countOfRows = GetNaturalNumber("Введите количество строк: ");
int countOfColumns = GetNaturalNumber("Введите количество столбцов: ");
int[,] matrix = InitAndFill2DArray(countOfRows, countOfColumns);

Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();

SelectionSortReverse(matrix);

Console.WriteLine($"->\n");
PrintMatrix(matrix);


// The example displays the following output:

// Введите количество строк: 5
// Введите количество столбцов: 5

//     6    2    5    3    0
//     8    1    5    9    5
//     9    9    6    1    2
//     0    3    8    0    4
//     0    8    6    8    7

// ->

//     6    5    3    2    0
//     9    8    5    5    1
//     9    9    6    2    1
//     8    4    3    0    0
//     8    8    7    6    0