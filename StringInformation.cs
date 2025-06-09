namespace Homework_Strings_and_Symbols;

public class StringInformation
{
    public void Example()
    {
        Console.WriteLine("\nExample: ");
        Output("AbCdFg");
    }

    public void UserInput()
    {
        Console.Write("\nEnter string: ");
        Output(Console.ReadLine());
    }

    void Output(string str)
    {
        Console.WriteLine("Number of characters in the string: " + str.Length);
        Console.WriteLine("String uppercase: " + str.ToUpper());
        Console.WriteLine("String lowercase: " + str.ToLower());
    }
}