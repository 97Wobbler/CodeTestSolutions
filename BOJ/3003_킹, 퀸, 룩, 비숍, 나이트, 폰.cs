int[] standard = { 1, 1, 2, 2, 2, 8 };

string[] inputs = Console.ReadLine().Split();
int[] numbers = inputs.Select(int.Parse).ToArray();

List<int> results = new List<int>();

for (int index = 0; index < 6; index++)
{
    results.Add(standard[index] - numbers[index]);
}

string result = string.Join(" ", results);

Console.WriteLine(result);