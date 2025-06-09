using System.Text;

namespace Homework_Strings_and_Symbols;

public class StringsToStringBuilder
{
    public void Example()
    {
        Console.WriteLine("\nExample: ");
        Output(new List<string>(){"123", "456", "789"});
    }

    public void UserInput()
    {
        List<string> strList = new List<string>();
        while (true)
        {
            Console.Write("Add string to array (type <<exit>> to complete): ");
            string input = Console.ReadLine();
            if (input == "exit")
            {
                Output(strList);
                break;
            }
            else
            {
                strList.Add(input);
            }
        }
    }

    private void Output(List<string> str)
    {
        StringBuilder strBuild = new StringBuilder();
        for (int i = 0; i < str.Count; i++)
        {
            strBuild.Append(str[i]);
            strBuild.Append(" ");
        }
        Console.WriteLine(strBuild.ToString());
    }
}