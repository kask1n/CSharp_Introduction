/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int GetRandomValue()
{
  return new Random().Next(100, 1000);
}

int DeleteSecondDigit(int number)
{
  return (number / 100) * 10 + (number % 10);
}

int num = GetRandomValue();
int result = DeleteSecondDigit(num);
Console.WriteLine($"Было {num}, стало {result}");