/*
Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
      Y
   2  |  1
      |
--------------> X
      |
   3  |  4

3. Вывести на консоль результат.
*/

int GetNumber(string message)
{
  int resultNumber = 0;

  while (true)
  {
    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber != 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!");
    }
  }
  return resultNumber;
}

int GetQuarter(int x, int y)
{
  if (x > 0 && y > 0)
    return 1;
  else if (x < 0 && y > 0)
    return 2;
  else if (x < 0 && y < 0)
    return 3;
  else
    return 4;
}

int x = GetNumber("Введите координату X, которая не равна 0: ");
int y = GetNumber("Введите координату Y, которая не равна 0: ");
int quarter = GetQuarter(x, y);
Console.WriteLine($"Точка с координатами {x} и {y} лежит в {quarter} четверти.");

// void TempFunction(out int x)
// {
//   x = x * 100;
// }

// int number = 12;
// TempFunction(number);
// Console.WriteLine(number);

// var item = new MyClass { X = 10 };
// AnotherTempFunction(item);
// Console.WriteLine(item.X);

/*

Типы данных: 
1. Ссылочные (reference types);
- Хранятся в управляемой куче
- Классы, листы, массивы, chars (символы)

2. Значимые (values types);
- Хранятся в стеке (оперативной памяти)
- int, double, datetime, long, enum, struct, byte, float

3. string

*/