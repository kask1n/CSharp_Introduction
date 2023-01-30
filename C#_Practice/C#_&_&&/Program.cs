bool Question_one(int[] a)
{
  a[0] = 20;
  return false;
}
bool Question_two(int[] a)
{
  a[0] = 30;
  return true;
}

int[] a = { 10 };
Console.WriteLine();
if (Question_one(a) && Question_two(a)) // И: Проверка по порядку слева направо с прерыванием после первого false.
{
  Console.WriteLine("Условие && выполнилось");
}
Console.WriteLine("&& a[0]=" + a[0]);

a[0] = 10;
Console.WriteLine();
if (Question_one(a) & Question_two(a)) // И: Проверка по порядку слева направо без прерывания для всех выражений подряд.
{
  Console.WriteLine("Условие & выполнилось");
}
Console.WriteLine("& a[0]=" + a[0]);

a[0] = 10;
Console.WriteLine();
if (Question_two(a) || Question_one(a)) // ИЛИ: Проверка по порядку слева направо с прерыванием после первого false.
{
  Console.WriteLine("Условие || выполнилось");
}
Console.WriteLine("|| a[0]=" + a[0]);

a[0] = 10;
Console.WriteLine();
if (Question_two(a) | Question_one(a)) // ИЛИ: Проверка по порядку слева направо без прерывания для всех выражений подряд.
{
  Console.WriteLine("Условие | выполнилось");
}
Console.WriteLine("| a[0]=" + a[0]);