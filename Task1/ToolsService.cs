namespace Task1;

public static class ToolsService
{
    public static int? ReadLineAndParseToInt()
    {
        var line = Console.ReadLine();

        if (line == null || line.Trim() == "") 
        { 
            Console.WriteLine(ErrorCode.EmptyInput);
            return null;
        }

        if (int.TryParse(line, out var result))
        { 
            return result; 
        }
        
        Console.WriteLine(ErrorCode.NotNumber);
        return null;
    }
    
    public static bool ValidateNumber(int a)
    {
        switch (a)
        {
            case 0:
                Console.WriteLine(ErrorCode.ZeroNumber);
                return false;
            case < 0:
                Console.WriteLine(ErrorCode.NegativeNumber);
                return false;
            default:
                return true;
        }
    }
}