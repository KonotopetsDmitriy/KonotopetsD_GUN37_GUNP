namespace Homework_Strings_and_Symbols;

public class FiveSymbolsOfString
{
    public void Example()
    {
        Console.WriteLine("\nExample: ");
        string str = "abcdefghijklmnop";
        Output(str);
    }

    public void UserInput()
    {
        Console.Write("Enter the string: ");
        string str = Console.ReadLine();
        Output(str);
    }

    public void Output(string str)
    {
        Console.WriteLine($"First five symbols of the string: {str.Substring(0,5)}");
    }
}