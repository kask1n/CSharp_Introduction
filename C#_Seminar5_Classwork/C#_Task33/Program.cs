/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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

bool FindNumber(int find, int[] arr)
{
  bool result = false;
  for (int i = 0; i < arr.Length; i++)
  {
    if (find == arr[i])
    {
      result = true;
      break;
    }
  }
  return result;
}

Console.WriteLine();
int[] array = InitArray(10);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");

Console.WriteLine("Что будем искать?");
int find = Convert.ToInt32(Console.ReadLine());
bool a = FindNumber(find, array);

if (a)
  Console.WriteLine("-> Да, искомый элемент найден.");
else
  Console.WriteLine("-> Нет, искомое отсутствует.");