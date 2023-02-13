/*
Перебор слов.
В некотором машинном алфавите имеются четыре буквы "а", "и", "с" и "в".
Покажите все слова, состоящие из Т букв, которые можно построить из букв этого алфавита.
*/

void FindWordsSpecialCase() // Частный случай для слов длиной 5 символов.
{
  char[] s = { 'а', 'и', 'с', 'в' };
  int count = s.Length;
  int n = 1;

  for (int i = 0; i < count; i++)
  {
    for (int j = 0; j < count; j++)
    {
      for (int k = 0; k < count; k++)
      {
        for (int l = 0; l < count; l++)
        {
          for (int m = 0; m < count; m++)
          {
            Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
          }
        }
      }
    }
  }
}

int n = 1;
void FindWordsRec(string alphabet, char[] word, int length = 0) // Общий случай через рекурсию для слов длиной n символов.
{
  if (length == word.Length)
  {
    Console.WriteLine($"{n++,-7}{new String(word)}"); return;
  }

  for (int i = 0; i < alphabet.Length; i++)
  {
    word[length] = alphabet[i];
    FindWordsRec(alphabet, word, length + 1);
  }
}

Console.WriteLine();

// FindWordsSpecialCase();
FindWordsRec("аисв", new char[5]);

// TODO: Общий случай без рекурсии для слов длиной n символов.