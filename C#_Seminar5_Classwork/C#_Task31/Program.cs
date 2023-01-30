/*
Демонстрация решения
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
сумма положительных чисел равна 29, сумма отрицательных равна -20.

Алгоритм решения:
1. Инициализируем массив
2. Печатаем массив
3. Находим сумму положительных в массиве
4. Находим сумму отрицательных в массиве
5*. Сумма отрицательных и положительных через один метод
*/


// 1. Инициализируем массив

int[] InitArray(int dimension)
{
  int[] arr = new int[dimension];
  Random rnd = new Random();

  for (int i = 0; i < dimension; i++)
  {
    arr[i] = rnd.Next(-9, 10);
  }
  return arr;
}


// 2. Печатаем массив

void PrintArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{arr[i]} ");
  }

  Console.WriteLine();
}


// 3. Находим сумму положительных в массиве

int GetPositiveSum(int[] array)
{
  int sum = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
      sum += array[i];
  }

  return sum;
}


// 4. Находим сумму отрицательных в массиве

int GetNegativeSum(int[] array)
{
  int sum = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < 0)
      sum += array[i];
  }

  return sum;
}


// 5*. Сумма отрицательных и положительных через один метод

(int, int) GetSummsFromArray(int[] array) // Пример кортежа (тип возвращаемых данных может быть другим - double, string и т.п.)
{
  int posSum = 0;
  int negSum = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < 0)
      negSum += array[i];
    else
      posSum += array[i];
  }

  return (posSum, negSum); // Будет работать ТОЛЬКО в точно такой же последовательности, как указано в кортеже.
}


MySum Temp(int[] array) // Решение через собственный класс.
{
  MySum item = new MySum();

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < 0)
      item.NegativeSum += array[i];
    else
      item.PositiveSum += array[i];
  }
  return item;
}


Console.WriteLine();
int[] array = InitArray(12);
PrintArray(array);
int posSum = GetPositiveSum(array);
int negSum = GetNegativeSum(array);

(int pos, int neg) = GetSummsFromArray(array);

MySum item = Temp(array);

Console.WriteLine($"Сумма положительных = {posSum}, отрицательных = {negSum}");
Console.WriteLine($"Сумма положительных = {pos}, отрицательных = {neg}");
Console.WriteLine($"Сумма положительных = {item.PositiveSum}, отрицательных = {item.NegativeSum}");


class MySum // Создание собственного класса для альтернативного решения.
{
  public int PositiveSum { get; set; }
  public int NegativeSum { get; set; }
}