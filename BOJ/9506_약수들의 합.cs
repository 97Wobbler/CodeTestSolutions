using System.Linq;

int N = int.Parse(Console.ReadLine());

while (N != -1)
{
    List<int> divisors = new List<int>();

    for (int i = 1; i < N; i++)
    {
        if (N % i == 0) divisors.Add(i);
    }

    if (N == divisors.Sum())
    {
        Console.WriteLine(N + " = " + string.Join(" + ", divisors));
    }
    else
    {
        Console.WriteLine(N + " is NOT perfect.");
    }
    
    N = int.Parse(Console.ReadLine());
}