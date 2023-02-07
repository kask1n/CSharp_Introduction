Roots Solve(double a, double b, double c)
{
  var d = b * b - 4 * a * c;
  double x1 = (-b + Math.Sqrt(d)) / (2 * a);
  double x2 = (-b - Math.Sqrt(d)) / (2 * a);
  return new Roots { X1 = x1, X2 = x2 };
}

Console.WriteLine();
double a = 4;
double b = -12;
double c = 5;
Roots roots = Solve(a, b, c);
Console.WriteLine($"Для квадратного уравнения вида y = {a} * x^2 + {b} * x + {c} корнями являются x1 = {roots.X1} и x2 = {roots.X2}.");

class Roots
{
  public double X1 { get; set; }
  public double X2 { get; set; }
}