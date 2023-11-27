int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int a1 = numbers[0];
int a0 = numbers[1];

int c = int.Parse(Console.ReadLine());
int n0 = int.Parse(Console.ReadLine());

int f = a1 * n0 + a0;

if (f <= c * n0 && c * n0 >= a1)
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(0);
}