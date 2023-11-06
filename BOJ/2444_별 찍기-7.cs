using System.Text;

int n = int.Parse(Console.ReadLine());

int totoalLine = n * 2 - 1;
StringBuilder resultBuilder = new StringBuilder();

int spaceCount;
int starCount;

for (int i = 0; i < totoalLine; i++)
{
    resultBuilder.Clear();

    spaceCount = Math.Abs(n - i - 1);
    starCount = totoalLine - 2 * spaceCount;

    resultBuilder.Append(' ', spaceCount);
    resultBuilder.Append('*', starCount);

    Console.WriteLine(resultBuilder);
}