// string path = "E:/Git/2023.01.11_C#_Introduction/C#_Lection1/Examples/Example001_HelloConsole";

// DirectoryInfo di = new DirectoryInfo(path); // Класс для работы с директориями.
// System.Console.WriteLine(di.CreationTime);

// FileInfo[] fi = di.GetFiles(); // Класс для работы с файлами.

// for (int i = 0; i < fi.Length; i++)
// {
//   System.Console.WriteLine(fi[i].Name);
// }

void CatalogInfo(string path, string indent = "")
{
  DirectoryInfo catalog = new DirectoryInfo(path); // Создаём экземпляр класса для работы с директориями.
  DirectoryInfo[] catalogs = catalog.GetDirectories(); // Создаём массив класса со вложенными папками.

  for (int i = 0; i < catalogs.Length; i++) // Цикл для вложенных директорий.
  {
    Console.WriteLine($"{indent}{catalogs[i].Name}"); // Вывод на экран текущей директории.
    CatalogInfo(catalogs[i].FullName, indent + " "); // Рекурсивный вызов метода.
  }

  FileInfo[] files = catalog.GetFiles(); // Создаём экземпляр класса для работы с файлами.

  for (int i = 0; i < files.Length; i++)
  {
    Console.WriteLine($"{indent}{files[i].Name}"); // Цикл для вывода на экран файлов из текущей папки.
  }
}

Console.WriteLine();
string path = @"E:/Git/2023.01.11_C#_Introduction/C#_Lection1/Examples/Example001_HelloConsole";
CatalogInfo(path);