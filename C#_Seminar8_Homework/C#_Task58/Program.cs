/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
      matrix[i, j] = rnd.Next(0, 2); // [0; 2)
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

void MultiplyMatrixAndPrint(int[,] A, int[,] B)
{
  int rA = A.GetLength(0);
  int cA = A.GetLength(1);
  int rB = B.GetLength(0);
  int cB = B.GetLength(1);

  if (cA == rB)
  {
    Console.WriteLine("A * B. -> Результат умножения матриц:\n");
    int temp;
    int[,] multiply = new int[rA, cB];

    for (int i = 0; i < rA; i++)
    {
      for (int j = 0; j < cB; j++)
      {
        temp = 0;

        for (int k = 0; k < cA; k++)
        {
          temp += A[i, k] * B[k, j];
        }

        multiply[i, j] = temp;
      }
    }

    for (int i = 0; i < multiply.GetLength(0); i++)
    {
      for (int j = 0; j < multiply.GetLength(1); j++)
      {
        Console.Write($"{multiply[i, j],5}");
      }
      Console.WriteLine();
    }
  }

  else if (cB == rA)
  {
    Console.WriteLine("Умножение матриц возможно только с перестановкой, т.е. B * A." +
                      " -> Результат умножения матриц:\n");
    int temp;
    int[,] multiply = new int[rB, cA];

    for (int i = 0; i < rB; i++)
    {
      for (int j = 0; j < cA; j++)
      {
        temp = 0;

        for (int k = 0; k < cB; k++)
        {
          temp += B[i, k] * A[k, j];
        }

        multiply[i, j] = temp;
      }
    }

    for (int i = 0; i < multiply.GetLength(0); i++)
    {
      for (int j = 0; j < multiply.GetLength(1); j++)
      {
        Console.Write($"{multiply[i, j],5}");
      }
      Console.WriteLine();
    }
  }

  else
  {
    Console.WriteLine("-> Матрицы несовместимы и не могут быть перемножены!");
  }
}

Console.WriteLine();
int countOfRows = GetNaturalNumber("Введите количество строк матрицы A: ");
int countOfColumns = GetNaturalNumber("Введите количество столбцов матрицы A: ");
int[,] matrix1 = InitAndFill2DArray(countOfRows, countOfColumns);

countOfRows = GetNaturalNumber("Введите количество строк матрицы B: ");
countOfColumns = GetNaturalNumber("Введите количество столбцов матрицы B: ");
int[,] matrix2 = InitAndFill2DArray(countOfRows, countOfColumns);

Console.WriteLine();
Console.WriteLine("Дано две матрицы.");

Console.WriteLine("Матрица A:\n");
PrintMatrix(matrix1);
Console.WriteLine();

Console.WriteLine("Матрица B:\n");
PrintMatrix(matrix2);
Console.WriteLine();

MultiplyMatrixAndPrint(matrix1, matrix2);


// The example displays the following output:

// Введите количество строк матрицы A: 1
// Введите количество столбцов матрицы A: 2
// Введите количество строк матрицы B: 3
// Введите количество столбцов матрицы B: 4

// Дано две матрицы.
// Матрица A:

//     0    0

// Матрица B:

//     1    0    0    1
//     0    0    0    1
//     1    1    1    1

// -> Матрицы несовместимы и не могут быть перемножены!

// ----------------------------------------------------

// Введите количество строк матрицы A: 1
// Введите количество столбцов матрицы A: 2
// Введите количество строк матрицы B: 3
// Введите количество столбцов матрицы B: 1

// Дано две матрицы.
// Матрица A:

//     0    1

// Матрица B:

//     0
//     0
//     1

// Умножение матриц возможно только с перестановкой, т.е. B * A. -> Результат умножения матриц:

//     0    0
//     0    0
//     0    1

// ----------------------------------------------------

// Введите количество строк матрицы A: 2
// Введите количество столбцов матрицы A: 2
// Введите количество строк матрицы B: 2
// Введите количество столбцов матрицы B: 2

// Дано две матрицы.
// Матрица A:

//     0    0
//     0    1

// Матрица B:

//     1    1
//     1    1

// A * B. -> Результат умножения матриц:

//     0    0
//     1    1