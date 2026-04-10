using System.Text;
using Tools;

namespace Task1
{
    public static class TaskService
    {
        public static void Task1()
        {
            Console.WriteLine("1.1 RECTANGLE");
            Console.Write("a = ");
            var inputA = DigitsTools.ReadLineAndParseToInt();

            if (inputA == null || !DigitsTools.ValidateNumber(inputA.Value)) return;

            Console.Write("b = ");
            var inputB = DigitsTools.ReadLineAndParseToInt();

            if (inputB == null || !DigitsTools.ValidateNumber(inputB.Value)) return;

            Console.WriteLine($"Result: {inputA.Value * inputB.Value}");
        }

        public static void Task2()
        {
            Console.WriteLine("1.2 TRIANGLE");
            Console.Write("N = ");
            
            var inputN = DigitsTools.ReadLineAndParseToInt();
            if (inputN == null || !DigitsTools.ValidateNumber(inputN.Value)) return;

            var n = inputN.Value;

            var stars = new char[n];

            for (int i = 0; i < n; i++)
            {
                stars[i] = '*';
                Console.WriteLine(stars[0..(i + 1)]);
            }
        }

        public static void Task3()
        {
            Console.WriteLine("1.3 ANOTHER TRIANGLE");
            Console.Write("N = ");
            
            var inputN = DigitsTools.ReadLineAndParseToInt();
            if (inputN == null || !DigitsTools.ValidateNumber(inputN.Value)) return;

            var n = inputN.Value;
            var stars = new char[n];
            var spaces = new string(' ', n - 1);

            PrintTriangle(stars, spaces, n);
        }

        public static void Task4()
        {
            Console.WriteLine("1.4 X-MAS TREE");
            Console.Write("N = ");
            
            var inputN = DigitsTools.ReadLineAndParseToInt();
            if (inputN == null || !DigitsTools.ValidateNumber(inputN.Value)) return;

            var n = inputN.Value;

            var stars = new char[n + 1];
            var spaces = new string(' ', n);

            for (int k = 1, b = n; k <= n + 1; k++, b--)
            {
                PrintTriangle(stars, spaces, k, b);
            }
        }

        public static void Task5()
        {
            Console.WriteLine("1.5 SUM OF NUMBERS");

            var sum = 0;

            for (var i = 0; i < 1000; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Result: {sum}");
        }

        [Flags]
        private enum SelectionType: byte
        {
            None = 0,
            bold = 1,
            italic = 2,
            underline = 4
        }

        public static void Task6()
        {
            Console.WriteLine("1.6 FONT ADJUSTMENT");

            var currentSelectionType = SelectionType.None;
            var selectionTypesNames = Enum.GetNames(typeof(SelectionType));
            var selectionTypesSB = new StringBuilder();

            for (int i = 1, k = 1; i < selectionTypesNames.Length; i++, k *= 2)
                selectionTypesSB.Append($"\t{i}: {(SelectionType)k}\n");
            selectionTypesSB.Append("\t0: exit\n");

            while (true)
            {
                Console.WriteLine($"Параметры надписи: {currentSelectionType}");
                Console.WriteLine("Введите:");
                Console.Write(selectionTypesSB.ToString());

                var inputTypeNumber = DigitsTools.ReadLineAndParseToInt();

                if (inputTypeNumber == null || inputTypeNumber == 0) 
                    return;

                if (inputTypeNumber >= selectionTypesNames.Length)
                {
                    Console.WriteLine(ErrorCode.IndexOutOfRange);
                    continue;
                }

                var inputSelectionType = (SelectionType)Enum.Parse(typeof(SelectionType), selectionTypesNames[inputTypeNumber.Value]);

                currentSelectionType ^= inputSelectionType;
            }
        }
        public static void Task7()
        {
            Console.WriteLine("1.7 ARRAY PROCESSING");
            const int n = 10;
            var arr = (int[])ArrayTools.FillArrayRandomValues(new int[n], 0, 100);

            var sortArr = TreeSort(arr);

            Console.WriteLine($"Initial array: {string.Join(", ", arr)}");
            Console.WriteLine($"Sorted array: {string.Join(", ", sortArr)}");
            Console.WriteLine($"Min: {sortArr[0]}\tMax: {sortArr[n-1]}");
        }
        public static void Task8()
        {
            Console.Write("1.8 NO POSITIVE");
            const int n = 3;
            var arr = (int[,,])ArrayTools.FillArrayRandomValues(new int[n,n,n], 0, 100);

            Console.Write("[");
            for (var i = 0; i < n; i++)
            {
                Console.Write("[");
                for (int j = 0; j < n; j++)
                {
                    Console.Write("[");
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write(arr[i,j,k]);
                        Console.Write(", ");
                    }
                    Console.Write("], ");
                }
                Console.Write("], ");
            }
            Console.WriteLine("], ");
        }
        public static void Task9()
        {
            Console.WriteLine("");
        }
        public static void Task10()
        {
            Console.WriteLine("");
        }
        public static void Task11()
        {
            Console.WriteLine("");
        }
        public static void Task12()
        {
            Console.WriteLine("");
        }

        private static void PrintTriangle(char[] stars, string spaces, int n, int bias = 0)
        {
            for (var i = 0; i < n; i++)
            {
                Console.Write(spaces[..(n - i - 1 + bias)]);

                stars[i] = '*';
                Console.Write(stars[..(i + 1)]);

                if (i == 0)
                {
                    Console.WriteLine();
                    continue;
                }

                Console.Write(stars[..i]);
                Console.Write(spaces[..bias]);
                Console.WriteLine();
            }
        }

        private static int[] TreeSort(int[] array)
        {
            var treeNode = new TreeNode(array[0]);
            for (var i = 1; i < array.Length; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }

            return treeNode.Transform();
        }
    }
}
