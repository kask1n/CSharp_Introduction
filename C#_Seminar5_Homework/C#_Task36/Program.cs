/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] InitAndFillArray(int dimension)
{
  int[] arr = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    arr[i] = rnd.Next(-99, 100); // [-99; 100) = [-99; 99]
  }
  return arr;
}

int SumNumbersInOddIndexes(int[] arr)
{
  var sum = 0;
  for (int i = 1; i < arr.Length; i = i + 2)
  {
    sum = sum + arr[i];
  }

  return sum;
}

Console.WriteLine();

int dimension = 6;
int[] array = InitAndFillArray(dimension);
int sum = SumNumbersInOddIndexes(array);

Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"-> Сумма чисел из нечётных индексов указанного массива = {sum}");


// The example displays the following output:

// Массив: [-81, 69, -58, 88]
// -> Сумма чисел из нечётных индексов указанного массива = 157

// Массив: [-81, 65, 73, 5, 94]
// -> Сумма чисел из нечётных индексов указанного массива = 70

// Массив: [41, -80, -99, -57, 27, 59]
// -> Сумма чисел из нечётных индексов указанного массива = -78