using System.Net.Mime;
using System;
namespace Homework_Collections;


class Program
{
    private class Task1()
    {
        private readonly List<int> _listOfInts = new List<int>(){1,2,3,4,5};
        private int _number;
        public void TaskLoop()
        {
            Console.WriteLine("Task 1\nEnter new number at the end of the list (int):");
            _listOfInts.Add(CheckInputInt());
            
            Console.WriteLine("------");//Вывод
            for (int i = 0; i < _listOfInts.Count; i++)
            {
                Console.WriteLine(_listOfInts[i]);
            }
            Console.WriteLine("------");
            
            Console.WriteLine("Enter new number at the middle of the list:");//Ввод в середину списка
            
            _listOfInts.Insert(_listOfInts.Count/2, CheckInputInt());
            
            Console.WriteLine("------");
            for (int i = 0; i < _listOfInts.Count; i++)
            {
                Console.WriteLine(_listOfInts[i]);
            }
            Console.WriteLine("------");
            BreakTask();
        }
    }
    
    private class Task2()
    {
        private readonly Dictionary<string, int> _students = new Dictionary<string, int>();
        private int averageGrade;
        private string studentName;
        public void TaskLoop()
        {
            Console.Write("Enter the student's name: ");
            
            while (true) //Проверка на пустой ввод
            {
                studentName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(studentName) == false)
                {
                    break;
                }
                Console.WriteLine("No data entered. Try again.");
            }
            
            Console.Write("Enter his average grade (2-5): ");
            
            while (true)
            {
                averageGrade = CheckInputInt();
                if (averageGrade >= 2 && averageGrade <= 5)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Must be between 2 and 5.");
            }
            _students.Add(studentName, averageGrade);
            Menu();
            void Menu(){ 
                Console.WriteLine("Enter command «add»,«find» or «exit»");
                switch (Console.ReadLine())
                    {
                        case "add":
                            TaskLoop();
                            break;
                        case "find":
                            Console.Write("Enter the student's name: ");
                            while (true)
                            {
                                studentName = Console.ReadLine();
                                if (_students.ContainsKey(studentName))
                                {
                                    Console.WriteLine("Average grade: " + _students[studentName]);
                                    Menu();
                                }
                                Console.WriteLine("Student not found. Try again.");
                            }
                            break;
                        case "exit":
                            Environment.Exit(0);
                            break;
                        default: Console.WriteLine("Invalid command.");
                            Menu();
                            break;
                    }
            }
        }
    }

    private class Task3()
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }

            public Node(int data)
            {
                Data = data;
                Next = null;
                Previous = null;
            }
        }
        
        public class DoublyLinkedList // Класс двусвязного списка
        {
            private Node head;
            private Node tail;
            private int size;

            public DoublyLinkedList()
            {
                head = null;
                tail = null;
                size = 0;
            }

            public void Add(int data) // Добавление элемента в конец списка
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.Next = newNode;
                    newNode.Previous = tail;
                    tail = newNode;
                }

                size++;
            }

            public void DisplayForward() // Вывод списка в прямом порядке
            {
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }

                Console.WriteLine();
            }

            public void DisplayBackward() // Вывод списка в обратном порядке
            {
                Node current = tail;
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Previous;
                }

                Console.WriteLine();
            }

            public int Size() // Получение размера списка
            {
                return size;
            }

            public void CreateList(int count) // Метод для создания списка с проверкой количества элементов
            {
                Console.WriteLine("\nEnter list elements (int):");
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Element {i + 1}: ");
                    int value = CheckInputInt();
                    Add(value);
                }
            }

            public static bool ValidateCount(int count) // Метод для проверки корректности количества элементов
            {
                return count >= 3 && count <= 6;
            }
        }

        public void TaskLoop()
        {
            Console.WriteLine("Enter the number of elements (from 3 to 6, must be Integer): ");
        
            // Ввод количества элементов
            int count;
            do
            {
                Console.Write("Number of elements: ");
                count = CheckInputInt();
            } while (!DoublyLinkedList.ValidateCount(count));

            // Создание и заполнение списка
            DoublyLinkedList list = new DoublyLinkedList();
            list.CreateList(count);

            // Вывод списка
            Console.WriteLine("\nList in forward order:");
            list.DisplayForward();

            Console.WriteLine("\nList in backward order:");
            list.DisplayBackward();

            BreakTask();
        }
    }
    
    
    
    
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 1,2 or 3 to check task 1,2 or 3");
        if (int.TryParse(Console.ReadLine(), out int task))// Используйте tryParse
        {
            switch (task) 
            {
                case 1:
                    CheckTaskFirst(); // Выполнение задания в отдельном методе
                    break;
                case 2:
                    CheckTaskSecond();
                    break;
                case 3:
                    CheckTaskThird();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Wrong input!");
        }
        
    }
    
    private static void CheckTaskFirst()
    {
        var task1 = new Task1();
        task1.TaskLoop();
    }
    private static void CheckTaskSecond()
    {
        var task2 = new Task2();
        task2.TaskLoop();
    }
    private static void CheckTaskThird()
    {
        var task3 = new Task3();
        task3.TaskLoop();
    }
    
    private static void BreakTask()//Выход из программы
    {
        Console.WriteLine("Type «exit» to close the program");
        while (Console.ReadLine() !=  "exit" )
        { 
            Console.WriteLine("Wrong command");
        }
        Environment.Exit(0);
    }

    public static int CheckInputInt()//Проверка на int
    {
        int number;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out number))
            {
                return number;
            }
            Console.WriteLine("Wrong input! Must be integer. Try again");
        }
    }
}