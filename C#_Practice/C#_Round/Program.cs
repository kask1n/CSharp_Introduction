double a = 1.25;
double b = 1.15;
double c = -1.25;
double d = -1.15;

Console.WriteLine();
Console.WriteLine($"Начальные значения:\na = {a}, b = {b}, c = {c}, d = {d}\n");
Console.WriteLine($"Округление только для вывода на экран через :f1 (равносильно ToZero):\na = {a:f1}, b = {b:f1}, c = {c:f1}, d = {d:f1}\n");
Console.WriteLine($"По умолчанию ToEven, округление среднего значения к ближайшему чётному:\na = {Math.Round(a, 1)}, b = {Math.Round(b, 1)}, c = {Math.Round(c, 1)}, d = {Math.Round(d, 1)}\n");
Console.WriteLine($"AwayFromZero, округление среднего к ближайшему наиболее удалённому от нуля:\na = {Math.Round(a, 1, MidpointRounding.AwayFromZero)}, b = {Math.Round(b, 1, MidpointRounding.AwayFromZero)}, c = {Math.Round(c, 1, MidpointRounding.AwayFromZero)}, d = {Math.Round(d, 1, MidpointRounding.AwayFromZero)}\n");
Console.WriteLine($"ToEven (см. выше):\na = {Math.Round(a, 1, MidpointRounding.ToEven)}, b = {Math.Round(b, 1, MidpointRounding.ToEven)}, c = {Math.Round(c, 1, MidpointRounding.ToEven)}, d = {Math.Round(d, 1, MidpointRounding.ToEven)}\n");
Console.WriteLine($"ToNegativeInfinity, округление среднего к ближайшему к минус бесконечности:\na = {Math.Round(a, 1, MidpointRounding.ToNegativeInfinity)}, b = {Math.Round(b, 1, MidpointRounding.ToNegativeInfinity)}, c = {Math.Round(c, 1, MidpointRounding.ToNegativeInfinity)}, d = {Math.Round(d, 1, MidpointRounding.ToNegativeInfinity)}\n");
Console.WriteLine($"ToPositiveInfinity, округление среднего к ближайшему к плюс бесконечности:\na = {Math.Round(a, 1, MidpointRounding.ToPositiveInfinity)}, b = {Math.Round(b, 1, MidpointRounding.ToPositiveInfinity)}, c = {Math.Round(c, 1, MidpointRounding.ToPositiveInfinity)}, d = {Math.Round(d, 1, MidpointRounding.ToPositiveInfinity)}\n");
Console.WriteLine($"ToZero, округление среднего к ближайшему наиболее близкому к нулю:\na = {Math.Round(a, 1, MidpointRounding.ToZero)}, b = {Math.Round(b, 1, MidpointRounding.ToZero)}, c = {Math.Round(c, 1, MidpointRounding.ToZero)}, d = {Math.Round(d, 1, MidpointRounding.ToZero)}\n");