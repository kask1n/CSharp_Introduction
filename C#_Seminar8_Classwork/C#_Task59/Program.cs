/*
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:
9 4 2
2 2 6
3 4 7
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
      matrix[i, j] = rnd.Next(0, 10); // [-10; 10)
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
      Console.Write($"{matrix[i, j],7}");
    }
    Console.WriteLine();
  }
}

(int, int) FindMinIndexes(int[,] matrix)
{
  int min = matrix[0, 0];
  int minI = 0;
  int minJ = 0;

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i, j] < min)
      {
        min = matrix[i, j];
        minI = i;
        minJ = j;
      }
    }
  }

  return (minI, minJ);
}

int[,] ArrayWithoutMinRowAndMinColumn(int[,] matrix, int minI, int minJ)
{
  int[,] trimArray = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    if (i == minI) continue;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (j == minJ) continue;

      if (i < minI && j < minJ)
        trimArray[i, j] = matrix[i, j];
      else if (i > minI && j < minJ)
        trimArray[i - 1, j] = matrix[i, j];
      else if (i < minI && j > minJ)
        trimArray[i, j - 1] = matrix[i, j];
      else if (i > minI && j > minJ)
        trimArray[i - 1, j - 1] = matrix[i, j];
    }
  }

  return trimArray;
}

Console.WriteLine();
int countOfRows = GetNaturalNumber("Введите количество строк: ");
int countOfColumns = GetNaturalNumber("Введите количество столбцов: ");
int[,] matrix = InitAndFill2DArray(countOfRows, countOfColumns);

Console.WriteLine();
PrintMatrix(matrix);

(int minI, int minJ) = FindMinIndexes(matrix);
Console.WriteLine();
Console.WriteLine($"-> Первое вхождение наименьшего элемента массива находится в [{minI}, {minJ}].\n");

Console.WriteLine("После удаления строки и столбца с наименьшим элементом получаем новый массив:\n");
int[,] newMatrix = ArrayWithoutMinRowAndMinColumn(matrix, minI, minJ);
PrintMatrix(newMatrix);