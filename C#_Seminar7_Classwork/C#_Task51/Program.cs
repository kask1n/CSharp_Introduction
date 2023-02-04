/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1 + 9 + 2 = 12
*/

int GetNumber(string message)
{
  int result = 0;

  while (true)
  {
    Console.WriteLine(message);

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

int[,] InitMatrix(int rows, int columns)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = rnd.Next(1, 10);
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
      Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
  }
}

int SumNumbersOfDiagonalIndexesThrough2Cycles(int[,] matrix) // Способ через двойной цикл (цикл в цикле).
{
  int sum = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i == j)
        sum = sum + matrix[i, j];
    }
  }

  return sum;
}

int SumNumbersOfDiagonalIndexesThrough1Cycle(int[,] matrix) // Способ через одинарный цикл.
{
  int sum = 0;
  int count = 0;

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    if (i == count)
      sum = sum + matrix[i, i];
    count++;
  }

  return sum;
}

Console.WriteLine();
int countOfRows = GetNumber("Введите количество строк: ");
int countOfColumns = GetNumber("Введите количество столбцов: ");
int[,] matrix = InitMatrix(countOfRows, countOfColumns);

Console.WriteLine();
PrintMatrix(matrix);

Console.WriteLine();
int sum2Cycles = SumNumbersOfDiagonalIndexesThrough2Cycles(matrix);
Console.WriteLine($"-> Сумма элементов из основной диагонали указанной матрицы = {sum2Cycles}");

int sum1Cycle = SumNumbersOfDiagonalIndexesThrough1Cycle(matrix);
Console.WriteLine($"-> Сумма элементов из основной диагонали указанной матрицы = {sum2Cycles}");