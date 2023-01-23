string GetString()
{
  Console.WriteLine("Введите строку:");
  string str = Console.ReadLine();
  return str;
}

int StringToInt(string a)
{
  int strInt = Convert.ToInt32(a);
  return strInt;
}

double StringToDouble(string b)
{
  double strDouble = Convert.ToDouble(b);
  return strDouble;
}

string str1 = GetString();
int int1 = StringToInt(str1);
double double1 = StringToDouble(str1);

Console.WriteLine($"С помощью функции GetString компьютер фиксирует строку {str1}.");
Console.WriteLine($"С помощью функции StringToInt компьютер фиксирует число {int1}.");
Console.WriteLine($"С помощью функции StringToDouble компьютер фиксирует число {double1}.");