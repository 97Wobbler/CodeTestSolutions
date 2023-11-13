string[] inputs = Console.ReadLine().Split();
int a = int.Parse(inputs[0]);
int b = int.Parse(inputs[1]);

while (a != 0 && b != 0)
{
    if (b % a == 0)
    {
        Console.WriteLine("factor");
    }
    else if (a % b == 0)
    {
        Console.WriteLine("multiple");
    }
    else {
        Console.WriteLine("neither");
    }

    inputs = Console.ReadLine().Split();
    a = int.Parse(inputs[0]);
    b = int.Parse(inputs[1]);
}