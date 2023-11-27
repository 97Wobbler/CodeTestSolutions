class Choi
{
    static int N;
    static int M;
    static char[,] board;
    static int cellsToPaintCountMin = 32;
    static void Main()
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        N = numbers[0];
        M = numbers[1];

        board = new char[N, M];

        for (int row = 0; row < N; row++)
        {
            char[] lineChars = Console.ReadLine().ToCharArray();

            for (int col = 0; col < M; col++)
            {
                board[row, col] = lineChars[col];
            }
        }

        for (int row = 0; row < N - 8 + 1; row++)
        {
            for (int col = 0; col < M - 8 + 1; col++)
            {
                int newCellsToPaintCount = GetCellsToPaintCount(row, col);

                if (newCellsToPaintCount < cellsToPaintCountMin)
                {
                    cellsToPaintCountMin = newCellsToPaintCount;
                }
            }
        }

        Console.WriteLine(cellsToPaintCountMin);
    }

    static int GetCellsToPaintCount(int offsetY, int offsetX)
    {
        int cellCountToPaint = 0;

        for (int dy = 0; dy < 8; dy++)
        {
            int y = offsetY + dy;

            for (int dx = 0; dx < 8; dx++)
            {
                int x = offsetX + dx;

                bool shouldBlack = (dx + dy) % 2 == 0;
                bool isBlack = board[y, x] == 'B';

                if (shouldBlack != isBlack) cellCountToPaint++;
            }
        }

        if (cellCountToPaint > 32) cellCountToPaint = 64 - cellCountToPaint;

        return cellCountToPaint;
    }
}