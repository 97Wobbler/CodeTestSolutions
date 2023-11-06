class Choi
{
    static void Main()
    {
        string input = Console.ReadLine();
        int time = 0;

        foreach (char c in input)
        {
            time += GetTime(c);
        }

        Console.WriteLine(time);
    }

    static int GetTime(char letter)
    {
        int dialIndex = (letter) switch {
            <= 'C' => 2,
            <= 'F' => 3,
            <= 'I' => 4,
            <= 'L' => 5,
            <= 'O' => 6,
            <= 'S' => 7,
            <= 'V' => 8,
            <= 'Z' => 9,
            _ => 0
        };

        int timeInSeconds = 1 + dialIndex;
        return timeInSeconds;
    }
}