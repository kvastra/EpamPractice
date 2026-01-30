namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        var next = true;
        
        while(next)
        {
            Console.WriteLine("\nChoose the task number.\n(Enter 0 (zero) if you'd like to exit)");
            Console.Write("Task number: ");

            var inputNumber = TaskService.ReadLineAndParseToInt();
            
            if (inputNumber == null) continue;

            var taskNumber = inputNumber.Value;

            Console.WriteLine();

            switch (taskNumber)
            {
                case 0:
                    {
                        next = false;
                        return;
                    }
                case 1:
                    {
                        TaskService.Task1();
                        break;
                    }
                case 2:
                    {
                        TaskService.Task2();
                        break;
                    }
                case 3:
                    {
                        TaskService.Task3();
                        break;
                    }
                case 4:
                    {
                        TaskService.Task4();
                        break;
                    }
                case 5:
                    {
                        TaskService.Task5();
                        break;
                    }
                case 6:
                    {
                        TaskService.Task6();
                        break;
                    }
                case 7:
                    {
                        TaskService.Task7();
                        break;
                    }
                case 8:
                    {
                        TaskService.Task8();
                        break;
                    }
                case 9:
                    {
                        TaskService.Task9();
                        break;
                    }
                case 10:
                    {
                        TaskService.Task10();
                        break;
                    }
                case 11:
                    {
                        TaskService.Task11();
                        break;
                    }
                case 12:
                    {
                        TaskService.Task12();
                        break;
                    }
                default:
                    {
                        Console.WriteLine(ErrorCode.IndexOutOfRange);
                        break;
                    }
            }

            Console.WriteLine();
        }
    }
}