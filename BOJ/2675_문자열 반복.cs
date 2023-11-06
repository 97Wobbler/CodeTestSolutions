int T = int.Parse(Console.ReadLine());

string[] inputs;
string result;

int repeat;
string letters;
int length;

for (int i = 0; i < T; i++)
{
    result = "";
    inputs = Console.ReadLine().Split();

    repeat = int.Parse(inputs[0]);
    letters = inputs[1];

    length = letters.Length;

    foreach (char c in letters)
    {
        for (int j = 0; j < repeat; j++)
        {
            result += c;
        }
    }

    Console.WriteLine(result);
}