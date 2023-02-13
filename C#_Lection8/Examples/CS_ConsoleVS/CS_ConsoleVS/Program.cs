using System;
using System.Linq;
using System.Text;
using System.Net.Http;
using CS_ListMaster;

namespace CS_ConsoleVS
{
    class Program
    {
        static public void Main(string[] args)
        {
            ArrayMaster am = new(); // Использование пользовательского класса.

            for (int i = 0; i < 10; i++)
            {
                am.Add(new Random().Next(1, 5));
            }

            // am.Add(1);

            for (int i = 0; i < am.GetCount(); i++)
            {
                Console.WriteLine(am.GetValue(i));
            }

            // Console.WriteLine(am.GetValue(0));
            // Console.WriteLine(am.GetValue(1));
            // Console.WriteLine(am.GetValue(2));
            // Console.WriteLine(am.GetValue(3));
            // Console.WriteLine(am.GetValue(4));

            // if (args.Length >= 1)
            // {
            //     if (args[0] == "0") Console.WriteLine("Hello, World!");
            //     Console.WriteLine($"Hello, {args[0].Replace("-", "")}!");
            // }
            // Console.ReadKey();
        }
    }
}