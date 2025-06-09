namespace Homework_Strings_and_Symbols;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine
            ("Menu:\n" +
             "1. Concatenate 2 strings\n" +
             "2. Greetings to User\n" +
             "3. Returning a string in uppercase and lowercase\n" +
             "4. Returning first 5 symbols of the string\n" +
             "5. Array of strings to StringBuilder\n" +
             "6. Word replacement\n");
        Console.Write("Enter a menu item: ");
        switch (Console.ReadLine())
        {
            case "1":
                CheckConcatenateStrings();
                break;
            case "2":
                CheckGreetUser();
                break;
            case "3":
                CheckStringInformation();
                break;
            case "4":
                CheckFiveSymbolsOfString();
                break;
            case "5":
                CheckStringsToStringBuilder();
                break;
            case "6":
                CheckReplaceWord();
                break;
            default:
                Console.WriteLine("Wrong input");
                break;
        }
    }

    private static void CheckConcatenateStrings()
    {
        var concatenateStrings = new ConcatenateStrings();
        concatenateStrings.Example();
        concatenateStrings.UserInput();
    }
    private static void CheckGreetUser()
    {
        var greetUser = new GreetUser();
        greetUser.Example();
        greetUser.UserInput();
    }
    private static void CheckStringInformation()
    {
        var stringInfo = new StringInformation();
        stringInfo.Example();
        stringInfo.UserInput();
    }
    private static void CheckFiveSymbolsOfString()
    {
        var fiveSym = new FiveSymbolsOfString();
        fiveSym.Example();
        fiveSym.UserInput();
    }
    private static void CheckStringsToStringBuilder()
    {
        var srtBld = new StringsToStringBuilder();
        srtBld.Example();
        srtBld.UserInput();
    }
    private static void CheckReplaceWord()
    {
        var replWrd = new ReplaceWord();
        replWrd.Example();
        replWrd.UserInput();
    }
}
    