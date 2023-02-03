/*
Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного копирования.
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

int[] CopyArray(int[] startArr)
{
  int[] arr = new int[startArr.Length];

  for (int i = 0; i < startArr.Length; i++)
  {
    arr[i] = startArr[i];
  }
  return arr;
}

Console.WriteLine();
int dimension = 8;
int[] array = InitArray(dimension);
Console.WriteLine("Массив 1: [{0}]",string.Join(", ", array));

int[] copyArray = CopyArray(array);
Console.WriteLine("Массив 2: [{0}]",string.Join(", ", copyArray));