int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a + b + c != 180)
{
    Console.WriteLine("Error");
}
else
{
    if (a == b && b == c)
    {
        Console.WriteLine("Equilateral");
    }
    else if (a == b || b == c || a == c)
    {
        Console.WriteLine("Isosceles");
    }
    else
    {
        Console.WriteLine("Scalene");
    }
}