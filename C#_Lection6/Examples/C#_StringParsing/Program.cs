using System.Linq;

string text = "(1,2) (2,3) (4,5) (9,7)"
                .Replace("(", "")
                .Replace(")", "")
                ;
Console.WriteLine();
Console.WriteLine(text);
Console.WriteLine();

var data = text.Split(" ") // Можно указать тип string[], но в общем виде лучше оставить var.
               .Select(item => item.Split(','))
               .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // Т.н. лямбды - функционал в C#.
               .Where(e => e.x % 2 == 0)
               .Select(point => (point.x * 10, point.y + 10))
               .ToArray();

for (int i = 0; i < data.Length; i++)
{
  Console.WriteLine(data[i]);
  // for (int k = 0; k < data[i].Length; k++)
  // {
  //   Console.WriteLine(data[i][k]);
  // }
}