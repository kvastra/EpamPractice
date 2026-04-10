namespace Tools;

public static class ArrayTools
{
    public static Array FillArrayRandomValues(Array array, int min = -10, int max = 10) 
        => FillArrayWithValues(array, () => StaticRandom.Random.Next(min, max)); 
    
    public static Array FillArrayWithValues(Array array, Func<int> next) 
        => FillArrayRandomValuesRec(array.Rank, array, new int[array.Rank], next);

    private static Array FillArrayRandomValuesRec(int rank, Array array, int[] indexes, Func<int> next)
    {
        if (rank == 1)
        {
            for (var i = 0; i < array.GetLength(rank-1); i++)
            {
                indexes[array.Rank - rank] = i;
                array.SetValue(next(), indexes);
            }
        }
        else
        {
            for (var i = 0; i < array.GetLength(rank-1); i++) {
                indexes[array.Rank - rank] = i;
                FillArrayRandomValuesRec(rank - 1, array, indexes, next);
            }
        }

        return array;
    }
}