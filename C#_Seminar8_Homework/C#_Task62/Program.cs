﻿/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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
      matrix[i, j] = rnd.Next(-10, 10); // [-10; 10)
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

void FindAndPrintMeanOfEachColumn(int[,] matrix)
{
  Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");

  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    var sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      sum = sum + matrix[i, j];
    }

    var mean = (double)sum / matrix.GetLength(0);
    Console.Write("{0,7:f1}", mean);
  }

  Console.WriteLine();
}

Console.WriteLine();
int countOfRows = GetNaturalNumber("Введите количество строк: ");
int countOfColumns = GetNaturalNumber("Введите количество столбцов: ");
int[,] matrix = InitAndFill2DArray(countOfRows, countOfColumns);

Console.WriteLine();
PrintMatrix(matrix);

Console.WriteLine();
FindAndPrintMeanOfEachColumn(matrix);


// The example displays the following output: