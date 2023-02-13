// Собрать строку с числами от a до b, a <= b.

string NumbersForUp(int a, int b)
{
  string result = String.Empty;

  for (int i = a; i <= b; i++)
  {
    result += $"{i} ";
  }

  return result;
}

string NumbersRecUp(int a, int b)
{
  if (a < b) return $"{a} " + NumbersRecUp(a + 1, b);
  else if (a == b) return $"{b}";
  else return String.Empty;
}

string NumbersForDown(int a, int b)
{
  string result = String.Empty;

  for (int i = a; i >= b; i--)
  {
    result += $"{i} ";
  }

  return result;
}

string NumbersRecDown(int a, int b)
{
  if (a < b) return NumbersRecDown(a + 1, b) + $"{a} ";
  else if (a == b) return $"{b} ";
  else return String.Empty;
}

Console.WriteLine("\n{0}", NumbersForUp(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine("{0}", NumbersRecUp(1, 10)); // 1 2 3 4 5 6 7 8 9 10

Console.WriteLine("\n{0}", NumbersForDown(10, 1)); // 10 9 8 7 6 5 4 3 2 1
Console.WriteLine("{0}", NumbersRecDown(1, 10)); // 10 9 8 7 6 5 4 3 2 1