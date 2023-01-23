using System.Diagnostics;

System.Console.WriteLine("Hello, World");
int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var sw = new Stopwatch();
int position = 0;
TimeSpan time = new TimeSpan();

for (int i = 0; i < 1_000_000; i++) // to collect average statistics
{
  sw.Start();
  int count = array.Length; // for comparsion between cycles w/var and wo/var

  while (position < count)
  {
    Console.Write(".");
    position++;
  }

  sw.Stop();
  time = time + sw.Elapsed;
}

Console.WriteLine(time / 1_000_000);