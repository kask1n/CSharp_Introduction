/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] InitArray(int dimension)
{
  int[] arr = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    arr[i] = rnd.Next(0, 1000);
  }
  return arr;
}

int FindCount(int[] arr)
{
  var count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] >= 10 && arr[i] < 100)
      count++;
  }
  return count;
}

Console.WriteLine();

int[] array = InitArray(10);
int count = FindCount(array);

Console.WriteLine($"Массив: [{string.Join(", ", array)}]");

Console.WriteLine($"-> Количество двухзначных чисел в указанном массиве: {count}");