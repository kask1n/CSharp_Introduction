/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int GetNaturalNumber(string message)
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

double[,] InitAndFill2DArray(int rows, int columns)
{
  double[,] matrix = new double[rows, columns];
  Random rnd = new Random();
  double temp;

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      temp = rnd.NextDouble() * (10 - (-10)) + (-10); // [-10; 10) = [-10; 9,9999...]
      matrix[i, j] = Math.Round(temp, 2, MidpointRounding.ToZero); // [-10; 10) = [-10; 9,99]
    }
  }

  return matrix;
}

void PrintMatrix(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}   ");
    }
    Console.WriteLine();
  }
}

Console.WriteLine();
int countOfRows = GetNaturalNumber("Введите количество строк: ");
int countOfColumns = GetNaturalNumber("Введите количество столбцов: ");
double[,] matrix = InitAndFill2DArray(countOfRows, countOfColumns);

Console.WriteLine();
PrintMatrix(matrix);


// The example displays the following output:

// Введите количество строк:
// 5
// Введите количество столбцов:
// 5

// 8,77   -9,77   3,17   -3,24   4,83
// 0,67   -1,39   -2,63   -6,9   -5,22
// 6,3   -7,31   8,33   -9,71   -7,95
// -6,73   0,64   8,02   3,47   -3,48
// -4,23   5,73   0,32   -3,61   -9,38