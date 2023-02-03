/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] InitAndFillArray(int dimension)
{
  int[] arr = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    arr[i] = rnd.Next(100, 1000); // [100; 1000)
  }
  return arr;
}

int FindEvenNumbers(int[] arr)
{
  var count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0)
      count++;
  }
  return count;
}

Console.WriteLine();

int dimension = 10;
int[] array = InitAndFillArray(dimension);
int count = FindEvenNumbers(array);

Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"-> Количество чётных чисел в указанном массиве: {count}");


// The example displays the following output:

// Массив: [690, 121, 813, 972, 538, 394, 552, 538, 385, 899]
// -> Количество чётных чисел в указанном массиве: 6

// Массив: [259, 907, 629, 809, 980, 523, 883, 605, 691, 737]
// -> Количество чётных чисел в указанном массиве: 1