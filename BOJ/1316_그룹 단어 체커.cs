class Choi
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < count; i++)
        {
            if (CheckIfGroupedWord()) sum++;
        }

        Console.WriteLine(sum);
    }

    static bool CheckIfGroupedWord()
    {
        string input = Console.ReadLine();
        int wordLength = input.Length;

        for (int i = 0; i < wordLength - 1; i++)
        {
            if (input[i] != input[i + 1])
            {
                char toCompare = input[i];
                int index = input.IndexOf(toCompare, i + 1);

                if (index != -1) return false;
            }
        }
        return true;
    }
}