using Tools.Models;

namespace Tools;

public static class SortingTools
{
    public static int[] TreeSort(int[] array)
    {
        var treeNode = new TreeNode(array[0]);
        for (var i = 1; i < array.Length; i++)
        {
            treeNode.Insert(new TreeNode(array[i]));
        }

        return treeNode.Transform();
    }
}