int N = int.Parse(Console.ReadLine());
int x = 2;

for (int i = 0; i < N; i++)
{
    x = 2 * x - 1;
}

Console.WriteLine(Math.Pow(x, 2));