double GetRandomNumber(double minimum, double maximum) // [minimum, maximum)
{
  Random random = new Random();
  return random.NextDouble() * (maximum - minimum) + minimum;
}

Console.WriteLine();
double result = GetRandomNumber(1.23, 5.34);
Console.WriteLine(result);