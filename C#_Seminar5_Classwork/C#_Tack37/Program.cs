/*
Задача 37: Найдите произведение пар чисел в одномерном массиве
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] InitArray(int dimension)
{
  int[] arr = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    arr[i] = rnd.Next(1, 10);
  }
  return arr;
}

int[] MultiOfNumbers(int[] arr)
{
  int[] newArr = null;
  bool even = true;

  if (arr.Length % 2 == 0)
    newArr = new int[arr.Length / 2];
  else
  {
    newArr = new int[arr.Length / 2 + 1];
    even = false;
  }

  for (int i = 0; i < newArr.Length; i++)
  {
    if (!even && i == newArr.Length - 1)
      newArr[i] = arr[i];
    else
      newArr[i] = arr[i] * arr[arr.Length - i - 1];
  }
  return newArr;
}

Console.WriteLine();

int[] array = InitArray(9);
Console.WriteLine(string.Join(", ", array));

Console.WriteLine("-> ");

int[] multiArray = MultiOfNumbers(array);
Console.WriteLine(string.Join(", ", multiArray));