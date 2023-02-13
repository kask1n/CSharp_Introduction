// Факториал N.

int FactorialFor(int n)
{
  int result = 1;

  for (int i = 2; i <= n; i++)
  {
    result *= i;
  }

  return result;
}

int FactorialRec(int n)
{
  if (n > 1) return n * FactorialRec(n - 1);
  else return 1;
}

Console.WriteLine("\n{0}", FactorialFor(10)); // 3628800
Console.WriteLine("{0}", FactorialRec(10)); // 3628800