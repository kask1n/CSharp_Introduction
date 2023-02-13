int[,] pic = new int[1000, 1000];

void PrintImage(int[,] image)
{
  for (int i = 0; i < image.GetLength(0); i++)
  {
    for (int j = 0; j < image.GetLength(1); j++)
    {
      // Console.Write($"{image[i, j]} ");
      if (image[i, j] == 0) Console.Write(" ");
      else Console.Write("+");
    }
    Console.WriteLine();
  }
}

void FillImage(int row, int col)
{
  if (pic[row, col] == 0)
  {
    pic[row, col] = 1;
    FillImage(row - 1, col);
    FillImage(row, col - 1);
    FillImage(row + 1, col);
    FillImage(row, col + 1);
  }
}


for (int i = 0; i < 1000; i++)
{
  pic[0, i] = 1;
  pic[i, 0] = 1;
  pic[i, 999] = 1;
  pic[999, i] = 1;
}

Console.WriteLine();
// PrintImage(pic);

Console.WriteLine();
FillImage(1, 1);
// PrintImage(pic);