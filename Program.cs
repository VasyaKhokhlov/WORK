using System;
using static System.Console;

Clear();
string[] primaryText = InputText($"Введите текст и нажмите Enter: ");
string[] result = ResultText(primaryText, $"Введите необходимую длину символов: ");
Write($"[{String.Join(" ", primaryText)}]");
Write($" -> [{String.Join(" ", result)}]");

string[] InputText(string text)
{
    Write(text);
    string[] arrayText = ReadLine().Split(" ");
    return arrayText;
}

int WordCount(string[] oldText, int size)
{
    int count = 0;
    for (int i = 0; i < oldText.Length; i++)
    {
        if (oldText[i].Length <= size) count++;
    }
    return count;
}

string[] ResultText(string[] oldText, string text)
{
    Write(text);
    int sizeWord = int.Parse(Console.ReadLine());
    int sizeNewText = WordCount(oldText, sizeWord);
    string[] newText = new string[sizeNewText];
    for (int i = 0, j = 0; i < oldText.Length; i++)
    {
        if (oldText[i].Length <= sizeWord)
        {
            newText[j] = oldText[i];
            j++;            
        }
    }
    return newText;
}