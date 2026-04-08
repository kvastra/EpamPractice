namespace Task1;

class Program
{
    private static Action GetTaskCall(int x) =>
        x switch
        {
            1 => TaskService.Task1,
            2 => TaskService.Task2,
            3 => TaskService.Task3,
            4 => TaskService.Task4,
            5 => TaskService.Task5,
            6 => TaskService.Task6,
            7 => TaskService.Task7,
            8 => TaskService.Task8,
            9 => TaskService.Task9,
            10 => TaskService.Task10,
            11 => TaskService.Task11,
            12 => TaskService.Task12,
            _ => throw new ArgumentOutOfRangeException(nameof(x), x, "Out of range")
        };

    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("\nChoose the task number.\n(Enter 0 (zero) if you'd like to exit)");
            Console.Write("Task number: ");

            var inputNumber = ToolsService.ReadLineAndParseToInt();
            
            if (inputNumber == null) continue;

            var taskNumber = inputNumber.Value;

            Console.WriteLine();

            if (taskNumber == 0)
            {
                break;
            }
            var action = GetTaskCall(taskNumber);
            action();

            Console.WriteLine();
        }
    }
}