/*
Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.

Например:
78 -> 8
12 -> 2
85 -> 8
*/

/*
1. Метод, который получает случайное число
2. Метод, который получает максимальную цифру числа
*/

// 1. Метод, который получает случайное число
int GetRandomNumber(int leftBound, int rightBound)
{
  int result = 0;
  Random rnd = new Random();

  result = rnd.Next(leftBound, rightBound + 1); // [leftBound, rightBound)
  return result;
}

// 2. Метод, который получает максимальную цифру числа
int GetMaxDigitOfNumber(int number)
{
  int firstDigit = number / 10; // 96 / 10 = 9,6 (округляется в меньшую сторону)
  int secondDigit = number % 10;
  if (firstDigit > secondDigit)
    return firstDigit;
  else
    return secondDigit;
}

int number = GetRandomNumber(10, 99);
int maxDigit = GetMaxDigitOfNumber(number);

Console.WriteLine($"Максимальная цифра числа {number} = {maxDigit}");