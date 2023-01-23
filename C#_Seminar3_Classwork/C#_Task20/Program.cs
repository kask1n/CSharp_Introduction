/*
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

int GetCoordFromUser(string message)
{
  int result = 0;

  while (true)
  {
    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out result) && result != 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!");
    }
  }
  return result;
}

double GetDistance(int ax, int ay, int bx, int by)
{
  double result = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));
  return result;
}

int ax = GetCoordFromUser("Введите X-координату 1-ой точки: ");
int ay = GetCoordFromUser("Введите Y-координату 1-ой точки: ");

int bx = GetCoordFromUser("Введите X-координату 2-ой точки: ");
int by = GetCoordFromUser("Введите Y-координату 2-ой точки: ");

double distance = GetDistance (ax, ay, bx, by);
Console.WriteLine($"Расстояние между {ax},{ay} и {bx},{by} составляет {distance}.");