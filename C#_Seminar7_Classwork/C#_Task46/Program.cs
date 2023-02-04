/*
Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1

Алгоритм решения:
1. Метод, инициализирующий матрицу
2. Метод, распечатывающий матрицу
3. Метод получения числа из консоли
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

Console.WriteLine();
int countOfRows = GetNumber("Введите количество строк: ");
int countOfColumns = GetNumber("Введите количество столбцов: ");
int[,] matrix = InitMatrix(countOfRows, countOfColumns);

Console.WriteLine();
PrintMatrix(matrix);