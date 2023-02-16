/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNaturalNumberOrZero(string message)
{
  int naturalNumber;

  while (true)
  {
    Console.Write(message);

    if (int.TryParse(Console.ReadLine()!, out naturalNumber) && naturalNumber >= 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!\n");
    }
  }

  return naturalNumber;
}

int Ackermann(int m, int n)
{
  if (m == 0) return n + 1;
  else if (m > 0 && n == 0) return Ackermann(m - 1, 1);
  else return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.WriteLine();
int m = GetNaturalNumberOrZero("Введите m (натуральное число или ноль): ");
int n = GetNaturalNumberOrZero("Введите n (натуральное число или ноль): ");

Console.WriteLine($"\n-> Результат функции Аккермана A({m},{n}) = {Ackermann(m, n)}");


// The example displays the following output:

// Введите m (натуральное число или ноль): 2
// Введите n (натуральное число или ноль): 3

// -> Результат функции Аккермана A(2,3) = 9
// --------------------------------

// Введите m (натуральное число или ноль): 3
// Введите n (натуральное число или ноль): 2

// -> Результат функции Аккермана A(3,2) = 29
// --------------------------------

// Введите m (натуральное число или ноль): 3
// Введите n (натуральное число или ноль): 4

// -> Результат функции Аккермана A(3,4) = 125
// --------------------------------

// Введите m (натуральное число или ноль): 4
// Введите n (натуральное число или ноль): 3
// Stack overflow.
// Repeat 19275 times:
// --------------------------------
//    at Program.<<Main>$>g__Ackermann|0_1(Int32, Int32)
// --------------------------------
//    at Program.<Main>$(System.String[])