class Choi
{
    static int constructor = 0;
    
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            if (N == GetFactorization(i))
            {
                constructor = i;
                break;
            }
        }

        Console.WriteLine(constructor);
    }

    static int GetFactorization(int n)
    {
        int result = n;
        while (n > 0)
        {
            result += n % 10;
            n = n / 10;
        }

        return result;
    }
}