using System.Text;
using System.Text.RegularExpressions;

namespace Homework_Strings_and_Symbols;

public class ReplaceWord
{
    public void Example()
    {
        Console.WriteLine("\nExample: ");
        Output("Hello World!", "world","Universe");
        Console.WriteLine();
    }

    public void UserInput()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.Write("Enter a word to replace: ");
        string wordToFind = Console.ReadLine();
        Console.Write("Enter a replacement word: ");
        string replaceWord = Console.ReadLine();
        Output(input, wordToFind, replaceWord);
    }

    public static void Output(string stringEdit, string wordFind, string wordReplace )
    {
        StringBuilder result = new StringBuilder();
        string[] words = Regex.Split(stringEdit, @"(\W+)");
        for (int i = 0; i < words.Length; i++)
        {
            string current = words[i];
            if (IsWord(current))
            {
                if (current.Equals(wordFind, StringComparison.OrdinalIgnoreCase)){
                    result.Append(wordReplace);
                }
                else 
                {
                    result.Append(current);
                }
            }
            else
            {
                result.Append(current);
            }
        }
        Console.WriteLine(result.ToString());
    }
    static bool IsWord(string str)
    {
        return Regex.IsMatch(str, @"\w+");
    }
}