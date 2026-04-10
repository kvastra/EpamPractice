using System.Text;

namespace Tools;

public static class ArrayTools
{
    public static Array FillArrayRandomValues(Array array, int min = -10, int max = 10) 
        => FillArrayWithValues(array, () => StaticRandom.Random.Next(min, max)); 
    
    public static Array FillArrayWithValues(Array array, Func<int> next) 
        => FillArrayRandomValuesRec(array, array.Rank, new int[array.Rank], next);

    private static Array FillArrayRandomValuesRec(Array array, int currentRank, int[] indexes, Func<int> next)
    {
        if (currentRank == 1)
        {
            for (var i = 0; i < array.GetLength(currentRank-1); i++)
            {
                indexes[array.Rank - currentRank] = i;
                array.SetValue(next(), indexes);
            }
        }
        else
        {
            for (var i = 0; i < array.GetLength(currentRank-1); i++) {
                indexes[array.Rank - currentRank] = i;
                FillArrayRandomValuesRec(array, currentRank - 1, indexes, next);
            }
        }

        return array;
    }

    public static string GetStringOfArray(Array array)
    {
        var sb = new StringBuilder();
        GetStringOfArrayRec(array, array.Rank, new int[array.Rank], sb);
        return sb.ToString();
    }

    private static void GetStringOfArrayRec(Array array, int currentRank, int[] indexes, StringBuilder output)
    {
        output.Append("[");
        if (currentRank == 1)
        {
            for (var i = 0; i < array.GetLength(currentRank - 1); i++)
            {
                indexes[array.Rank - currentRank] = i;
                output.Append(array.GetValue(indexes));

                if (i == array.GetLength(currentRank - 1) - 1)
                    break;

                output.Append(", ");
            }
        }
        else
        {
            for (var i = 0; i < array.GetLength(currentRank-1); i++) {
                indexes[array.Rank - currentRank] = i;
                GetStringOfArrayRec(array, currentRank - 1, indexes, output);
                
                if (i == array.GetLength(currentRank - 1) - 1)
                    break;

                output.Append(", ");
            }
        }
        
        output.Append("]");
    }
}