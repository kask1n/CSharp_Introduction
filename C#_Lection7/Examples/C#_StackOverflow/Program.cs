int i = 0;

void Rec()
{
  System.Console.WriteLine(i++);
  Rec();
}

Rec();