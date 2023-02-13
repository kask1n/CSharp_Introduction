int fRec = 0;
decimal fIte = 0;

int FibonacciRecursion(int n) // Рекурсивный метод нахождения чисел Фибоначчи, который работает в разы быстрее,
                              // чем такой же метод с переменными типов decimal.
{
  fRec++;
  return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
  fIte++;
  decimal result = 1;
  decimal f0 = 1;
  decimal f1 = 1;

  for (int i = 2; i <= n; i++)
  {
    result = f0 + f1;

    f0 = f1;
    f1 = result;
    fIte++;
  }

  return result;
}

//# 1 2 3 4 5 6
//V 1 1 2 3 5 8


Console.WriteLine();
Console.ReadLine();
Console.WriteLine();

DateTime dt = DateTime.Now;

for (int n = 10; n < 35; n++)
{
  Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"),-15}");
  fIte = 0;
}

System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();
Console.WriteLine();

dt = DateTime.Now;

for (int n = 10; n < 35; n++)
{
  Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"),-15}");
  fRec = 0;
}

System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();