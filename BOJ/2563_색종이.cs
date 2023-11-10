class Choi
{
    static int sheetLength = 10;
    static int canvasLength = 100;
    static int[,] grid = new int[canvasLength, canvasLength];
    static void Main()
    {
        int sheetCount = Int32.Parse(Console.ReadLine());

        for (int index = 0; index < sheetCount; index++)
        {
            string[] inputs = Console.ReadLine().Split();
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);

            FillGrid(x, y);
        }

        int result = GetWidth();
        Console.WriteLine(result);
    }

    static void FillGrid(int x, int y)
    {
        for (int dx = 0; dx < sheetLength; dx++)
        {
            int targetX = x + dx;

            for (int dy = 0; dy < sheetLength; dy++)
            {
                int targetY = y + dy;

                grid[targetX, targetY] = 1;
            }
        }
    }

    static int GetWidth()
    {
        int sum = 0;

        for (int x = 0; x < canvasLength; x++)
        {
            for (int y = 0; y < canvasLength; y++)
            {
                sum += grid[x, y];
            }
        }

        return sum;
    }
}