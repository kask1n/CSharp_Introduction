int[] GetUniqueNumbersArray(int length) // Метод создания массива уникальных чисел БЕЗ использования словаря.
{
  int[] numbersArray = new int[length];
  Random random = new Random();

  for (int i = 0; i < numbersArray.Length; i++)
  {
    int num = random.Next(10, 100);

    int j = 0;
    while (j < i) // Заполнение массива через цикл while без использования декремента (k--).
    {
      if (num == numbersArray[j])
      {
        num = random.Next(10, 100);
        j = 0;
      }
      else j++;
    }

    // for (int j = 0; j < i; j++) // Заполнение массива через цикл for с использованием
    //                             // декремента (k--) - не самый лучший вариант.
    // {
    //   if (num == numbersArray[j])
    //   {
    //     num = random.Next(10, 100);
    //     j = -1;
    //   }
    // }

    numbersArray[i] = num;
  }

  return numbersArray;
}

Console.WriteLine();
int[] array = GetUniqueNumbersArray(8);
Console.WriteLine(string.Join(", ", array));