using System.Text;
using Tools;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input array dimension: ");
        var arrayDimension = DigitsTools.ReadLineAndParseToInt();

        if (arrayDimension == null || !DigitsTools.ValidateNumber(arrayDimension.Value)) return;

        var subArraysDimensions = new int[arrayDimension.Value];
        var random = StaticRandom.Random;
        var count = 1;

        for (var i = 0; i < arrayDimension.Value; i++)
        {
            Console.Write($"Input sub array [{i}] dimension: ");
            var subArrayDim = DigitsTools.ReadLineAndParseToInt();
            
            if (subArrayDim == null || !DigitsTools.ValidateNumber(subArrayDim.Value)) return;

            subArraysDimensions[i] = subArrayDim.Value;
            count *= subArrayDim.Value;
        }

        var array = (int[])ArrayTools.FillArrayRandomValues(new int[count], 0, 100);
        
        Console.WriteLine(MakeStringFromArray(array, subArraysDimensions));

        array = SortingTools.TreeSort(array);
        
        Console.WriteLine(MakeStringFromArray(array, subArraysDimensions));
    }

    static string MakeStringFromArray(Array array, int[] dimensions)
    {
        var sb = new StringBuilder();
        var start = 0;
        MakeStringFromArrayRec(array, dimensions.Length, dimensions, sb, ref start);
        return sb.ToString();
    }

    static void MakeStringFromArrayRec(Array array, int currentRank, int[] dimensions, StringBuilder output, ref int start)
    {
        output.Append("[");
        if (currentRank == 1)
        {
            for (var i = start; i < start + dimensions[^1]; i++)
            {
                output.Append(array.GetValue(i));

                if (i == start + dimensions[^1] - 1)
                    break;

                output.Append(", ");
            }

            start += dimensions[^1];
        }
        else
        {
            for (var i = 0; i < dimensions[^currentRank]; i++) {
                MakeStringFromArrayRec(array, currentRank - 1, dimensions, output, ref start);
                
                if (i == dimensions[^currentRank] - 1)
                    break;

                output.Append(", ");
            }
        }
        
        output.Append("]");
    }
}