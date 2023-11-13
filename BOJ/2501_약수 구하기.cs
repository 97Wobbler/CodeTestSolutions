string[] inputs = Console.ReadLine().Split();

int N = int.Parse(inputs[0]);
int K = int.Parse(inputs[1]);

int divisor = 0;
int foundCount = 0;

for (int i = 1; i <= N; i++)
{
    if (N % i == 0)
    {
        divisor = i;
        foundCount++;

        if (foundCount == K) break;
    }
}

if (foundCount < K)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(divisor);
}