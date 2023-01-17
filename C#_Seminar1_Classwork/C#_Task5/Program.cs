/*
Задача №5. Напишите программу, которая на вход принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine(); // 22 -> "22"
int number = Convert.ToInt32(numberStr); // 22

for (int i = -number; i <= number; i++)
{
  if (i < number)
  {
    Console.Write(i + ", ");
  }
  else
  {
    Console.Write(i);
  }
}