class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input array dimension: ");
        if (!int.TryParse(Console.ReadLine().Trim(), out var arrayDimension))
            return;

        int[] subArrayDimensions = new int[arrayDimension];
        var random = new Random();

        for (int i = 0; i < arrayDimension; i++)
        {
            Console.Write($"Input sub array [{i}] dimension: ");
            if (!int.TryParse(Console.ReadLine().Trim(), out var subArrayDim))
                return;

            subArrayDimensions[i] = subArrayDim;
        }
    }
}