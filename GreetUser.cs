namespace Homework_Strings_and_Symbols;
public class GreetUser
{
    public void Example()//Пример
    {
        Console.WriteLine("\nExample: ");
        string name = "Bob";
        int age = 23;
        Output(name, age);
    }

    public void UserInput()
    {
        Console.Write("\nEnter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Output(name, age);
    }

    private void Output(string name,  int age)
    {
        Console.WriteLine($"Hello, {name}!\nYou are {age} years old.");
    }
}