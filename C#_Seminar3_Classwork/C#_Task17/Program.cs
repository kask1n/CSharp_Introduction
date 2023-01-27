/*
Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
      Y
   2  |  1
      |
--------------> X
      |
   3  |  4

Алгоритм решения:
1. Получить две координаты точки с консоли;
2. Получить четверть плоскости, на которой находится точка;
3. Вывести на консоль результат.
*/

int GetNumber(string message)
{
  int resultNumber = 0;

  while (true)
  {
    Console.WriteLine(message);

    // int number = Convert.ToInt32(Console.ReadLine()); // Начинали делать так - вручную конвертируя строку в целое число. При вводе текста выдаст ошибку.
    // int number2 = int.Parse(Console.ReadLine()); // Тоже пытается конвертировать строку в число, но при вводе текста также выдаст ошибку.
    // bool isCastSuccessfull = int.TryParse(Console.ReadLine()); // Функция безопасного конвертирования с проверкой числа, которая выдаёт результат true или false, избегая ошибки в программе.

    if (int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber != 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!\n");
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

Console.WriteLine();
int x = GetNumber("Введите координату X, которая не равна 0: ");
int y = GetNumber("Введите координату Y, которая не равна 0: ");
int quarter = GetQuarter(x, y);
Console.WriteLine($"Точка с координатами {x} и {y} лежит в {quarter} четверти.");

/*
int TempFunction(ref int x)
{
  // var x_asgdfasdfgasdfasdf = x; // Это происходит под капотом функции. При этом, за пределами данной функции ничего не изменяется.
  // x_asgdfasdfgasdfasdf = x_asgdfasdfgasdfasdf * 100; // Это происходит под капотом функции. При этом, за пределами данной функции ничего не изменяется.
  x *= 100;
  return x;
}

// int number = 23;
// TempFunction(number); // Если передаём значимый тип в функцию - то же самое, что и TempFunction(23);

// void AnotherTempFunction(MyClass item)
// {
//   item.X = item.X * 1000;
// }

int number = 12;
TempFunction(ref number);
Console.WriteLine(number);

// var item = new MyClass { X = 10 };
// AnotherTempFunction(item);
// Console.WriteLine(item.X);

// class MyClass
// {
//   public int X { get; set; }
// }
*/

/*
Типы данных в C# бывают: 
1. Ссылочные (reference types):
- Хранятся в управляемой куче
- Классы, листы, массивы, chars (символы, например: "f")

2. Значимые (value types):
- Хранятся в стеке (оперативной памяти), поэтому все сделать значимыми невозможно, т.к. ОЗУ ограничена. Иначе - outOfMemory.
- int, double, datetime, long, enum, struct, byte, float

3. string ("asdfasdfasdf")
*/