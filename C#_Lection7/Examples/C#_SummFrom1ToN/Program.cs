// Сумма чисел от 1 до N.

int SumFor(int n)
{
  int result = 0;

  for (int i = 1; i <= n; i++)
  {
    result += i;
  }

  return result;
}

int SumRec(int n)
{
  if (n == 1) return 1;
  else return n + SumRec(n - 1);
}

Console.WriteLine("\n{0}", SumFor(10)); // 55
Console.WriteLine("{0}", SumRec(10)); // 55