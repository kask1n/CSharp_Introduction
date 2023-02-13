string emp = String.Empty;
string[] binaryTree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                       0    1    2     3    4    5    6    7    8    9    10   11

void InOrderTraversal(int pos = 1)
{
  if (pos < binaryTree.Length)
  {
    int left = 2 * pos;
    int right = 2 * pos + 1;

    if (left < binaryTree.Length && !String.IsNullOrEmpty(binaryTree[left])) InOrderTraversal(left);
    Console.WriteLine(binaryTree[pos]);
    if (right < binaryTree.Length && !String.IsNullOrEmpty(binaryTree[right])) InOrderTraversal(right);
  }
}

Console.WriteLine();
InOrderTraversal();