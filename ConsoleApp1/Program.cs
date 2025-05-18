class Program
{
    static void Main(string[] args)
    {
        //Ввод первого числа
        Console.WriteLine("Enter first number:");
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Not a number!");
            return;
        }
        
        //Ввод второго числа
        Console.WriteLine("Enter second number:");
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Not a number!");
            return;
        }
        
        //Ввод оператора
        Console.WriteLine("Enter operator (^, |, &):");
        var s = Console.ReadLine();
        if (s.Length == 0 || s.Length > 1)
        {
            Console.WriteLine("Wrong sign");
            return;
        }
        
        //Проверка оператора и вывод результата
        switch (s[0])
        {
            case '^' :
                Console.WriteLine("Result of " + a + " ^ " + b + " = ");
                Console.WriteLine("Decimal: " + Convert.ToString(a ^ b,10));
                Console.WriteLine("Binary: " + Convert.ToString(a ^ b,2));
                Console.WriteLine("Hex: " + Convert.ToString(a ^ b, 16));
                break;
            case '&':
                Console.WriteLine("Result of " + a + " & " + b + " = ");
                Console.WriteLine("Decimal: " + Convert.ToString(a & b,10));
                Console.WriteLine("Binary: " + Convert.ToString(a & b,2));
                Console.WriteLine("Hex: "  + Convert.ToString(a & b,16));
                break;
            case '|':
                Console.WriteLine("Result of " + a + " | " + b + " = ");
                Console.WriteLine("Decimal: " + Convert.ToString(a | b,10));
                Console.WriteLine("Binary: " + Convert.ToString(a | b,2));
                Console.WriteLine("Hex: "  + Convert.ToString(a | b,16));
                break;
            default:
                Console.WriteLine("Wrong sign");
                return;
        }
    }
}




