/*
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве.
A (3, 6); B (2, 1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

double GetCoordFromUser(string message)
{
  Console.WriteLine();
  double result = 0;

  while (true)
  {
    Console.WriteLine(message);

    if (double.TryParse(Console.ReadLine(), out result))
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!\n");
    }
  }
  return result;
}

double GetDistance(double ax, double ay, double bx, double by)
{
  double result = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));
  return result;
}

double ax = GetCoordFromUser("Введите X-координату 1-ой точки: ");
double ay = GetCoordFromUser("Введите Y-координату 1-ой точки: ");

double bx = GetCoordFromUser("Введите X-координату 2-ой точки: ");
double by = GetCoordFromUser("Введите Y-координату 2-ой точки: ");

double distance = GetDistance(ax, ay, bx, by);
Console.WriteLine($"Расстояние между ({ax}; {ay}) и ({bx}; {by}) составляет {distance:f2}.");