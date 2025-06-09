namespace Homework_Strings_and_Symbols;

public class ConcatenateStrings
{
    public void Example()
    {
        Console.WriteLine("\nExample: ");
        string string1 = "123";
        string string2 = "456";
        Output(string1, string2);
    }

    public void UserInput()
    {
        Console.Write("Enter your first string: ");
        string string1 = Console.ReadLine();
        Console.Write("Enter your second string: ");
        string string2 = Console.ReadLine();
        Output(string1, string2);
    }

    public void Output(string string1, string string2)
    {
        Console.WriteLine(string1 + string2 + "\n");
    }
}