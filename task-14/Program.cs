using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== Hello to Task-14 Done By Yash =====");
            Console.WriteLine("1. Display Hello Message");
            Console.WriteLine("2. Addition, Subtraction, Product, Quotient of two numbers");
            Console.WriteLine("3. Perform operation based on choice");
            Console.WriteLine("4. Display your name 10 times");
            Console.WriteLine("5. Display all even numbers (for, while, do-while)");
            Console.WriteLine("6. Display all odd numbers (for, while, do-while)");
            Console.WriteLine("7. Display table of a number (for, while, do-while)");
            Console.WriteLine("8. Display numbers from 100 to 5 with a gap of 3");
            Console.WriteLine("9. Display integer variables in one line");
            Console.WriteLine("10. Display integer variables in separate lines");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hello, World!");
                    break;

                case 2:
                    int a = 10, b = 5;
                    Console.WriteLine($"Addition: {a + b}");
                    Console.WriteLine($"Subtraction: {a - b}");
                    Console.WriteLine($"Product: {a * b}");
                    Console.WriteLine($"Quotient: {a / b}");
                    break;

                case 3:
                    int x = 10, y = 5;
                    Console.WriteLine("Enter choice: 1-Add 2-Sub 3-Mul 4-Div");
                    int op = int.Parse(Console.ReadLine());
                    if (op == 1) Console.WriteLine($"Addition: {x + y}");
                    else if (op == 2) Console.WriteLine($"Subtraction: {x - y}");
                    else if (op == 3) Console.WriteLine($"Product: {x * y}");
                    else if (op == 4) Console.WriteLine($"Quotient: {x / y}");
                    else Console.WriteLine("Invalid Choice");
                    break;

                case 4:
                    for (int i = 1; i <= 10; i++) Console.WriteLine($"{i}. Yash Singh");
                    break;

                case 5:
                    Console.WriteLine("Even Numbers using for:");
                    for (int i = 2; i <= 20; i += 2) Console.Write(i + " ");
                    Console.WriteLine("\nEven Numbers using while:");
                    int j = 2;
                    while (j <= 20) { Console.Write(j + " "); j += 2; }
                    Console.WriteLine("\nEven Numbers using do-while:");
                    int k = 2;
                    do { Console.Write(k + " "); k += 2; } while (k <= 20);
                    Console.WriteLine();
                    break;

                case 6:
                    Console.WriteLine("Odd Numbers using for:");
                    for (int i = 1; i <= 20; i += 2) Console.Write(i + " ");
                    Console.WriteLine("\nOdd Numbers using while:");
                    int j2 = 1;
                    while (j2 <= 20) { Console.Write(j2 + " "); j2 += 2; }
                    Console.WriteLine("\nOdd Numbers using do-while:");
                    int k2 = 1;
                    do { Console.Write(k2 + " "); k2 += 2; } while (k2 <= 20);
                    Console.WriteLine();
                    break;

                case 7:
                    Console.Write("Enter a number: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Table using for:");
                    for (int i = 1; i <= 10; i++) Console.WriteLine($"{n} x {i} = {n * i}");
                    Console.WriteLine("Table using while:");
                    int j3 = 1;
                    while (j3 <= 10) { Console.WriteLine($"{n} x {j3} = {n * j3}"); j3++; }
                    Console.WriteLine("Table using do-while:");
                    int k3 = 1;
                    do { Console.WriteLine($"{n} x {k3} = {n * k3}"); k3++; } while (k3 <= 10);
                    break;

                case 8:
                    for (int i = 100; i >= 5; i -= 3) Console.Write(i + " ");
                    Console.WriteLine();
                    break;

                case 9:
                    int p = 10, q = 20, r = 30;
                    Console.WriteLine($"Values: {p}, {q}, {r}");
                    break;

                case 10:
                    int p2 = 10, q2 = 20, r2 = 30;
                    Console.WriteLine("p = " + p2);
                    Console.WriteLine("q = " + q2);
                    Console.WriteLine("r = " + r2);
                    break;

                case 0:
                    Console.WriteLine("Exiting... Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
}
