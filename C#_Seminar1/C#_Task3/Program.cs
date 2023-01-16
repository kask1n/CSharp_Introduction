/*
Задача №2. Напишите программу, которая на вход принимает число и выводит
на экран день недели.
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine(); // 22 -> "22"
int number = Convert.ToInt32(numberStr); // 22

if (number == 1)
{
  Console.WriteLine("Понедельник");
}
else if (number == 2)
{
  Console.WriteLine("Вторник");
}
else if (number == 3)
{
  Console.WriteLine("Среда");
}
else if (number == 4)
{
  Console.WriteLine("Четверг");
}
else if (number == 5)
{
  Console.WriteLine("Пятница");
}
else if (number == 6)
{
  Console.WriteLine("Суббота");
}
else if (number == 7)
{
  Console.WriteLine("Воскресенье");
}
else
{
  Console.WriteLine("Нет такого дня недели");
}