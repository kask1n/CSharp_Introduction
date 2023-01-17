/*
Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому.
Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

int GetNumber()
{
  Console.WriteLine("Введите число");
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

int firstNumber = GetNumber();
int secondNumber = GetNumber();

if (secondNumber % firstNumber == 0)
{
  Console.WriteLine("Второе число кратно первому");
}
else
{
  Console.WriteLine($"Второе число НЕ кратно первому, остаток {secondNumber % firstNumber}");
}