/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1, 0, 1, 1, 0, 1, 0, 0]

1. Создать массив
2. Заполнить массив
3. Вывести на экран
*/

int[] CreateArray(int x)
{
  int[] array = new int[x];
  return array;
}

void FillArray(int[] arr)
{
  Random randomNum = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = randomNum.Next(0, 2);
  }
}

void PrintArray(int[] ar)
{
  Console.Write($"[ ");
  for (int i = 0; i < ar.Length - 1; i++)
  {
    Console.Write($"{ar[i]}, ");
  }
  Console.Write($"{ar[ar.Length - 1]} ");
  Console.Write($"]\n");
}

Console.WriteLine();
int[] a = CreateArray(8);
FillArray(a);
PrintArray(a);
Console.WriteLine();