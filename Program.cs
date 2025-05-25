namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci
            int[] fibonacci = new int[10];
            for (int i = 0; i < fibonacci.Length; i++)
            {
                if (i < 2)
                {
                    fibonacci[i] = i;
                }
                else
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }

            var task1 = string.Join(", ", fibonacci);
            Console.WriteLine("Fibonacci:\n" + task1 + "\n");

            //Even numbers
            int[] evenNumbers = new int[10];
            int b = 0;
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0 && i != 0)
                {
                    evenNumbers[b] = i;
                    b++;
                }
            }
            var task2 = string.Join(", ", evenNumbers);
            Console.WriteLine("Even numbers: \n" + task2 + "\n");

            //Multiplication table (1-5)
            Console.WriteLine("Multiplication table (1-5):");
            int[,] multTable = new int[5,10];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    multTable[i, j] = (i + 1) * (j + 1);
                    Console.Write(multTable[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            //Password
            Console.WriteLine();
            string password = "qwerty";
            string userPassword;
            Console.WriteLine("Enter password: ");
            do
            {
                userPassword = Console.ReadLine();
                if (userPassword != password)
                {
                    Console.WriteLine("Wrong password\n");
                }
                else
                {
                    Console.WriteLine("Correct password");
                }
            }while(userPassword != "qwerty");
        }
    }
}



