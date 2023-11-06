class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(GetMostCommonCharacter(input));
    }

    static string GetMostCommonCharacter(string input)
    {
        Dictionary<char, int> charCounts = new Dictionary<char, int>();
        foreach (char c in input.ToUpper())
        {
            if (!charCounts.ContainsKey(c))
            {
                charCounts[c] = 1;
            }
            else
            {
                charCounts[c]++;
            }
        }

        int maxCount = 0;
        char mostCommonCharacter = new char();
        bool isTie = false;

        foreach (KeyValuePair<char, int> pair in charCounts)
        {
            if (pair.Value > maxCount)
            {
                maxCount = pair.Value;
                mostCommonCharacter = pair.Key;
                isTie = false;
            }
            else if (pair.Value == maxCount)
            {
                isTie = true;
            }
        }

        return isTie ? "?" : mostCommonCharacter.ToString();
    }
}