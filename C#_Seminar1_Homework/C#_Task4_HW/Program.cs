/*
Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine();
Console.Write($"Укажите количество чисел для сравнения: ");
string quantityStr = Console.ReadLine(); // 22 -> "22"
int quantity = Convert.ToInt32(quantityStr); // 22

if (quantity < 2)
{
  Console.WriteLine();
  Console.WriteLine($"Количество чисел для сравнения должно быть 2 или более");
}

else
{
  double[] numbers = new double[quantity];
  Console.WriteLine();
  
  for (int i = 0; i < quantity; i++)
  {
    Console.Write($"Введите число {i + 1}: ");
    string numsStr = Console.ReadLine(); // 22 -> "22"
    numbers[i] = Convert.ToDouble(numsStr); // 22
  }
  
  Console.WriteLine();
  double max = numbers[0];
  
  for (int i = 1; i < quantity; i++)
  {
    if (numbers[i] > numbers[0])
    {
      max = numbers[i];
    }
  }
  
  Console.WriteLine($"-> max = {max}");
}