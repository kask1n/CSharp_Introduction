/*
Задача №7. Напишите программу, которая принимает на вход трёхзначное число,
а на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine(); // 22 -> "22"
int number = Convert.ToInt32(numberStr); // 22
int result = number % 10;
Console.WriteLine($"Последней цифрой числа {number} является цифра {result}");

// string temp = "abc";
// char[] tempArray = new char[] { 'a', 'b', 'c' };
// char lastSymbol = temp[-1];