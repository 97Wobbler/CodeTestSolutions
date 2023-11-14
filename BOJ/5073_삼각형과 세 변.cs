using System.Linq;

int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a = numbers[0];
int b = numbers[1];
int c = numbers[2];

int sum = a + b + c;

while (sum != 0)
{
    int maxValue = numbers.Max();
    if (sum <= 2 * maxValue)
    {
        Console.WriteLine("Invalid");
    }
    else if (a == b && b == c)
    {
        Console.WriteLine("Equilateral");
    }
    else if (a != b && b != c && c != a)
    {
        Console.WriteLine("Scalene");
    }
    else
    {
        Console.WriteLine("Isosceles");
    }

    numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    a = numbers[0];
    b = numbers[1];
    c = numbers[2];

    sum = a + b + c;
}