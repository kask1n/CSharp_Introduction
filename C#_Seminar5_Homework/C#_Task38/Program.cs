/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
*/

double[] InitAndFillDoubleArray(int dimension)
{
  double[] arr = new double[dimension];
  Random rnd = new Random();
  double temp;

  for (int i = 0; i < dimension; i++)
  {
    temp = rnd.NextDouble() * (100 - (-100)) + (-100); // [-100; 100) = [-100; 99,9999...]
    arr[i] = Math.Round(temp, 2, MidpointRounding.ToZero); // [-100; 100) = [-100; 99,99]
  }

  return arr;
}

double FindMinAndMaxAndCalcDiff(double[] arr)
{
  double min = 0;
  double max = 0;

  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] < min)
      min = arr[i];

    else if (arr[i] > max)
      max = arr[i];
  }

  return max - min;
}

Console.WriteLine();

int dimension = 5;
double[] array = InitAndFillDoubleArray(dimension);
double diff = FindMinAndMaxAndCalcDiff(array);

Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
Console.WriteLine($"-> Разница между максимальным и минимальным элементами указанного массива = {diff:f2}");


// The example displays the following output:

// Массив: [86,06; 26,64; -97,14; -47,19; -87,68]
// -> Разница между максимальным и минимальным элементами указанного массива = 183,20

// Массив: [-5,01; 55,41; -75,35; 86,33; 87,4]
// -> Разница между максимальным и минимальным элементами указанного массива = 162,75

// Массив: [94,29; 9,84; -43,18; -62,67; -36,78]
// -> Разница между максимальным и минимальным элементами указанного массива = 156,96