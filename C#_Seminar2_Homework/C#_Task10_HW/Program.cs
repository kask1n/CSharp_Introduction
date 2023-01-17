/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


// int GetRandomNumber(int leftBound, int rightBound)
// {
//   int result = 0;
//   Random rnd = new Random();

//   result = rnd.Next(leftBound, rightBound + 1); // [leftBound, rightBound)
//   return result;
// }

// // 2. Метод, который получает максимальную цифру числа
// int GetMaxDigitOfNumber(int number)
// {
//   int firstDigit = number / 10; // 96 / 10 =9,6
//   int secondDigit = number % 10;
//   if (firstDigit > secondDigit)
//     return firstDigit;
//   else
//     return secondDigit;
// }

// int number = GetRandomNumber(10, 99);
// int maxDigit = GetMaxDigitOfNumber(number);

// Console.WriteLine($"Максимальная цифра числа {number} = {maxDigit}");