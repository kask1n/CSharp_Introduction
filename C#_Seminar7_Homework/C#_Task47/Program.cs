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
      Console.Write($"{matrix[i, j],9}");
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

//      8,79     0,28     2,75    -3,64     3,34
//     -7,54    -5,14     3,14    -9,45    -1,59
//     -2,73    -7,01    -9,96    -2,24     4,44
//      2,23     9,12     5,65    -7,19    -3,09
//      4,37    -4,64    -3,97     7,94     2,06