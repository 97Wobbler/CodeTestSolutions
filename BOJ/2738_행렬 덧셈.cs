class Choi
{
    static int n;
    static int m;

    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        n = int.Parse(inputs[0]);
        m = int.Parse(inputs[1]);

        int[,] a = new int[n, m];
        int[,] b = new int[n, m];

        ReadConsoleToGetMatrixValues(a);
        ReadConsoleToGetMatrixValues(b);

        int[,] sum = AddMatrices(a, b);

        PrintMatrixOnConsole(sum);
    }

    static void ReadConsoleToGetMatrixValues(int[,] matrix)
    {
        for (int row = 0; row < n; row++)
        {
            string[] rowValues = Console.ReadLine().Split();

            for (int column = 0; column < m; column++)
            {
                matrix[row, column] = int.Parse(rowValues[column]);
            }
        }
    }

    static int[,] AddMatrices(int[,] a, int[,] b)
    {
        int[,] result = new int[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int column = 0; column < m; column++)
            {
                result[row, column] = a[row, column] + b[row, column];
            }
        }

        return result;
    }

    static void PrintMatrixOnConsole(int[,] matrix)
    {
        for (int row = 0; row < n; row++)
        {
            List<int> rowValues = new List<int>();

            for (int column = 0; column < m; column++)
            {
                rowValues.Add(matrix[row, column]);
            }
            
            string result = string.Join(" ", rowValues);
            Console.WriteLine(result);
        }
    }
}