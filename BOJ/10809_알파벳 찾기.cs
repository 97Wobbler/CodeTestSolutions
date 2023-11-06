string input = Console.ReadLine();
List<int> indexes = new List<int>();

for (char c = 'a'; c <= 'z'; c++)
{
    indexes.Add(input.IndexOf(c));
}

string result = string.Join(" ", indexes);
Console.WriteLine(result);