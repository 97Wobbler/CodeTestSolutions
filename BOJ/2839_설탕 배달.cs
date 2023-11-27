int N = int.Parse(Console.ReadLine());

int bagTotal = -1;

int bag5 = N / 5;
int bag3 = (N % 5) / 3;

while (bag5 >= 0)
{
    if (bag3 * 3 + bag5 * 5 == N)
    {
        bagTotal = bag3 + bag5;
        break;
    }

    bag5--;
    bag3 = (N - 5 * bag5) / 3;
}

Console.WriteLine(bagTotal);