int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(numbers);
int a = numbers[0];
int b = numbers[1];
int c = numbers[2];

int sum = numbers.Sum();

if (a + b > c)
{
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine(2 * a + 2 * b - 1);
}