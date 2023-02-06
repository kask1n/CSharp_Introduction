/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
пользователь вводит индексы 10, 10 - такого элемента нет.
пользователь вводите индексы 0, 2 - выводим элеменет 7
*/

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
  Console.Write("Дан массив:\n");
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
  }
}

int GetNaturalNumberWithZero(string message)
{
  int result = -1;

  while (true)
  {
    Console.Write(message);

    if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
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

int FindValueByIndex(int[,] matrix, int desiredRow, int desiredColumn)
{
  int desiredValue = -1;

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i == desiredRow && j == desiredColumn)
        desiredValue = matrix[i, j];
    }
  }

  return desiredValue;
}

Console.WriteLine();

int countOfRows = 3;
int countOfColumns = 4;
int[,] matrix = InitMatrix(countOfRows, countOfColumns);
PrintMatrix(matrix);
Console.WriteLine();

int rowIndex = GetNaturalNumberWithZero("Введите индекс искомой строки, где 0 - первая строка: ");
int columnIndex = GetNaturalNumberWithZero("Введите индекс искомого столбца, где 0 - первый столбец: ");
Console.WriteLine();

if (rowIndex < matrix.GetLength(0) && columnIndex < matrix.GetLength(1))
{
  int desiredValue = FindValueByIndex(matrix, rowIndex, columnIndex);
  Console.WriteLine($"-> Значение искомого элемента матрицы с индексами [{rowIndex}; {columnIndex}] = {desiredValue}.");
}
else
{
  Console.WriteLine("-> Такого элемента нет.");
}


// The example displays the following output:

// Дан массив:
// 4 1 1 9
// 1 2 7 7
// 2 4 8 2

// Введите индекс искомой строки, где 0 - первая строка: qwer
// Ввели не число или некорректное число. Повторите ввод!
// Введите индекс искомой строки, где 0 - первая строка: -1
// Ввели не число или некорректное число. Повторите ввод!
// Введите индекс искомой строки, где 0 - первая строка: 2.2
// Ввели не число или некорректное число. Повторите ввод!
// Введите индекс искомой строки, где 0 - первая строка: 0
// Введите индекс искомого столбца, где 0 - первый столбец: 0

// -> Значение искомого элемента матрицы с индексами [0; 0] = 4.