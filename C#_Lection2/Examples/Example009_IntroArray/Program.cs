int MaxOf3(int arg1, int arg2, int arg3)
{
  int max = arg1;
  if (arg2 > max) max = arg2;
  if (arg3 > max) max = arg3;
  return max;
}

//               0   1   2   3   4   5   6   7   8
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };

int result = MaxOf3(
  MaxOf3(array[0], array[1], array[2]),
  MaxOf3(array[3], array[4], array[5]),
  MaxOf3(array[6], array[7], array[8]));

Console.WriteLine(result);