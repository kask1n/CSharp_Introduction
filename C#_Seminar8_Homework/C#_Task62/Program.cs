/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] matrix = new int[4, 4];

void SnakeFillMatrix(int row, int col, int count) // TODO: Скорректировать метод с приоритетом на движение вперёд.
{
  if (col < matrix.GetLength(1) && row < matrix.GetLength(0) && col >= 0 && row >= 0 && matrix[row, col] == 0)
  {

    matrix[row, col] = count;
    count++;
    SnakeFillMatrix(row, col + 1, count);
    SnakeFillMatrix(row + 1, col, count);
    SnakeFillMatrix(row, col - 1, count);
    SnakeFillMatrix(row - 1, col, count);
  }
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],3:D2}");
    }
    Console.WriteLine();
  }
}

int startRowIndex = 0;
int startColumnIndex = 0;
int startNumber = 1;
SnakeFillMatrix(startRowIndex, startColumnIndex, startNumber);
Console.WriteLine();

PrintMatrix(matrix);


// The example displays the following output:

//  01 02 03 04
//  16 15 14 05
//  11 12 13 06
//  10 09 08 07