static class ErrorCode
{
    public const string NotNumber = "The value entered is not a number.";
    public const string ZeroNumber = "The value zero is not allowed.";
    public const string NegativeNumber = "Negative value is not allowed.";
    public const string WrongTaskNumber = "There is no task with this number.";
}

class Program
{
    static bool ValidateNumber(int a)
    {
        if (a == 0)
        {
            Console.WriteLine(ErrorCode.ZeroNumber);
            return false;
        }

        if (a < 0)
        {
            Console.WriteLine(ErrorCode.NegativeNumber);
            return false;
        }

        return true;
    }

    static int CalculateRectangleArea(int a, int b) => a * b;

    static void PrintTriangle(int n)
    {
        var stars = new char[n];

        for (int i = 0; i < n; i++)
        {
            stars[i] = '*';
            Console.WriteLine(stars[0..(i+1)]);
        }
    }
    
    static void PrintAnotherTriangle(int n)
    {
        var stars = new char[n];
        var spaces = new string(' ', n-1);

        for (int i = 0; i < n; i++)
        {
            Console.Write(spaces[0..(n-i-1)]);
            
            stars[i] = '*';
            Console.Write(stars[0..(i + 1)]);

            if (i == 0)
            { 
                Console.WriteLine();
                continue;
            }

            Console.Write(stars[0..i]);
            Console.WriteLine();
        }
    }

    static void PrintXMasTree(int n)
    {
        var stars = new char[n+1];
        var spaces = new string(' ', n);

        Console.WriteLine(spaces + '*');

        for (int k = 2; k < n + 2; k++)
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write(spaces[0..(n - i)]);

                stars[i] = '*';
                Console.Write(stars[0..(i + 1)]);

                if (i == 0)
                {
                    Console.WriteLine();
                    continue;
                }

                Console.Write(stars[0..i]);
                Console.WriteLine();
            }
        }
    }

    static void Main(string[] args)
    {
        var next = true;
        
        while(next)
        {
            Console.WriteLine("Choose the task number.\n(Enter 0 (zero) if you'd like to exit)");
            Console.Write("Task number: ");

            if (!int.TryParse(Console.ReadLine().Trim(), out var taskNumber))
            {
                Console.WriteLine(ErrorCode.NotNumber);
                return;
            }

            Console.WriteLine();

            switch (taskNumber)
            {
                case 0:
                    next = false;
                    return;
                case 1:
                    Console.WriteLine("1.1 RECTANGLE");
                    Console.Write("a = ");
                    var a = int.Parse(Console.ReadLine().Trim());

                    if (!ValidateNumber(a)) break;

                    Console.Write("b = ");
                    var b = int.Parse(Console.ReadLine().Trim());

                    if (!ValidateNumber(b)) break;

                    Console.WriteLine($"Result: {CalculateRectangleArea(a, b)}");
                    break;
                case 2:
                    Console.WriteLine("1.2 TRIANGLE");
                    Console.Write("N = ");
                    var n2 = int.Parse(Console.ReadLine().Trim());

                    if (!ValidateNumber(n2)) break;

                    PrintTriangle(n2);

                    break;
                case 3:
                    Console.WriteLine("1.3 ANOTHER TRIANGLE");
                    Console.Write("N = ");
                    var n3 = int.Parse(Console.ReadLine().Trim());

                    if (!ValidateNumber(n3)) break;

                    PrintAnotherTriangle(n3);
                    break;
                case 4:
                    Console.WriteLine("1.4 X-MAS TREE");
                    Console.Write("N = ");
                    var n4 = int.Parse(Console.ReadLine().Trim());

                    if (!ValidateNumber(n4)) break;

                    PrintXMasTree(n4);
                    break;
                case 5:
                    Console.WriteLine("Task <<>>");
                    break;
                case 6:
                    Console.WriteLine("Task <<>>");
                    break;
                case 7:
                    Console.WriteLine("Task <<>>");
                    break;
                case 8:
                    Console.WriteLine("Task <<>>");
                    break;
                case 9:
                    Console.WriteLine("Task <<>>");
                    break;
                case 10:
                    Console.WriteLine("Task <<>>");
                    break;
                case 11:
                    Console.WriteLine("Task <<>>");
                    break;
                case 12:
                    Console.WriteLine("Task <<>>");
                    break;
                default:
                    Console.WriteLine(ErrorCode.WrongTaskNumber);
                    break;
            }

            Console.WriteLine();
        }
    }
}