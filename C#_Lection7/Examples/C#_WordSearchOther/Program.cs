List<string> AddChar(char[,] charMat, List<string> input, int Length)
{
  if (input.Count > 0 && Length < input.Last().Length) return input;
  List<string> result = new List<string>();

  foreach (string item in input)
  {
    for (int i = 0; i < charMat.GetLength(0); i++)
    {
      result.Add(item + charMat[i, item.Length]);
    }
  }

  result = AddChar(charMat, result, Length);
  return result;
}

Console.WriteLine("Введите кол-во строк в матрице");
int r = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в матрице");
int c = int.Parse(Console.ReadLine());

char[,] Matrix = new char[r, c];
Console.WriteLine("Заполните матрицу");

for (int i = 0; i < r; ++i)
{
  for (int j = 0; j < c; ++j)
  {
    Console.Write("Введите значение элемента матрицы для строки {0}, столбец {1}: ", i, j);
    var ch = Console.ReadLine().ToString();
    Matrix[i, j] = ch[0];
  }
}

Console.WriteLine();
Console.WriteLine("Получаем матрицу вида");

for (int count = 0; count < r; count++)
{
  for (int j = 0; j < c; j++)
  {
    Console.Write(" " + Matrix[count, j] + " ");
  }

  Console.WriteLine();
}

double qwe = Math.Pow(r, c);
List<string> input = new List<string>();

for (int I = 0; I < r; I++)
{
  input.Add(Matrix[I, 0].ToString());
}

Console.WriteLine(new string('-', 30));
List<string> result = AddChar(Matrix, input, c - 1);
int n = 1;
Console.WriteLine("Всего {0} комбинаций", result.Count());

foreach (string item in result)
{
  if (n == (int)qwe / r)
  {
    Console.WriteLine("  " + item + " ");
    n = 1;
  }
  else
  {
    Console.Write("  " + item + " ");
    n++;
  }
}
Console.WriteLine();