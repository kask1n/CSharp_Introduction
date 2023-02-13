// Вычислить a^n.

int PowerFor(int a, int n)
{
  int result = 1;

  for (int i = 1; i <= n; i++)
  {
    result *= a;
  }

  return result;
}

int PowerRec(int a, int n)
{
  return n == 0 ? 1 : PowerRec(a, n - 1) * a; // Укороченная запись ветвления if через тернарный оператор.
}

int PowerRecMath(int a, int n)
{
  if (n == 0) return 1;
  else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
  else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine("\n{0}", PowerFor(2, 10)); // 1024
Console.WriteLine("{0}", PowerRec(2, 10)); // 1024
Console.WriteLine("{0}", PowerRecMath(2, 10)); // 1024