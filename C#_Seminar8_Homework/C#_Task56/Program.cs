/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int[] FindSumOfEachRow(int[,] matrix)
{
  int[] sumOfEachRow = new int[matrix.GetLength(0)];

  for (int row = 0; row < matrix.GetLength(0); row++)
  {
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
      sumOfEachRow[row] = sumOfEachRow[row] + matrix[row, column];
    }
  }

  return sumOfEachRow;
}

int FindIndexOfMinValue(int[] arr)
{
  int minIndex = 0;

  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] < arr[minIndex])
      minIndex = i;
  }

  return minIndex;
}

Console.WriteLine();
int countOfRows = GetNaturalNumber("Введите количество строк: ");
int countOfColumns = GetNaturalNumber("Введите количество столбцов: ");
int[,] matrix = InitAndFill2DArray(countOfRows, countOfColumns);

Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();

int[] sumOfEachRow = FindSumOfEachRow(matrix);
int indexOfMinValueRow = FindIndexOfMinValue(sumOfEachRow);
Console.WriteLine($"-> Строка с наименьшей суммой элементов: {indexOfMinValueRow + 1}");

// The example displays the following output:

// Введите количество строк: 7
// Введите количество столбцов: 7

//     1    4    4    3    7    0    2
//     2    0    0    2    9    4    9
//     2    0    5    6    8    1    5
//     9    8    6    8    2    6    3
//     8    1    9    5    3    9    6
//     6    3    1    1    0    3    9
//     7    9    6    5    7    7    3

// -> Строка с наименьшей суммой элементов: 1