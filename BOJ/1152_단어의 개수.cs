string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine(0);
}
else
{
    string[] words = input.Trim().Split(' ');
    int wordsCount = words.Length;

    Console.WriteLine(wordsCount);
}