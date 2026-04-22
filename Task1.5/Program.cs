using Tools;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input array dimension: ");
        if (!int.TryParse(Console.ReadLine().Trim(), out var arrayDimension))
            return;

        var subArraysDimensions = new int[arrayDimension];
        var random = StaticRandom.Random;
        var count = 1;

        for (var i = 0; i < arrayDimension; i++)
        {
            Console.Write($"Input sub array [{i}] dimension: ");
            if (!int.TryParse(Console.ReadLine().Trim(), out var subArrayDim))
                return;

            subArraysDimensions[i] = subArrayDim;
            count *= subArrayDim;
        }

        var array = ArrayTools.FillArrayRandomValues(new int[count], 0, 100);
        
        
    }
}