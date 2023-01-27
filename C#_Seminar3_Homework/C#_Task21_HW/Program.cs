/*
Задача 21:
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.

A (3, 6, 8); B (2, 1,-7) -> 15.84
A (7,-5, 0); B (1,-1, 9) -> 11.53
*/

double GetCoordFromUser(string message)
{
  Console.WriteLine();
  double result;

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

double GetDistance(double ax, double ay, double az, double bx, double by, double bz)
{
  double result = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
  return result;
}

double ax = GetCoordFromUser("Введите X-координату 1-ой точки: ");
double ay = GetCoordFromUser("Введите Y-координату 1-ой точки: ");
double az = GetCoordFromUser("Введите Z-координату 1-ой точки: ");

double bx = GetCoordFromUser("Введите X-координату 2-ой точки: ");
double by = GetCoordFromUser("Введите Y-координату 2-ой точки: ");
double bz = GetCoordFromUser("Введите Z-координату 2-ой точки: ");

double distance = GetDistance(ax, ay, az, bx, by, bz);
Console.WriteLine($"Расстояние между ({ax}; {ay}; {az}) и ({bx}; {by}; {bz}) составляет {distance:f2}.");


// The example displays the following output:

// Введите X-координату 1-ой точки: 
// 100

// Введите Y-координату 1-ой точки: 
// 101

// Введите Z-координату 1-ой точки: 
// 100

// Введите X-координату 2-ой точки: 
// 100

// Введите Y-координату 2-ой точки: 
// -101

// Введите Z-координату 2-ой точки: 
// 100
// Расстояние между (100; 101; 100) и (100; -101; 100) составляет 202,00.