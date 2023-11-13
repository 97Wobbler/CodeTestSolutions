using System.Linq;

int N = int.Parse(Console.ReadLine());

int divider = 2;

while (N != 1)
{
    if (N % divider == 0)
    {
        N /= divider;
        Console.WriteLine(divider);
    }
    else
    {
        divider++;
    }
}