class Choi
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split();

        int count = 0;

        for (int i = 0; i < N; i++)
        {
            int number = int.Parse(inputs[i]);
            if (IsPrimeNumber(number)) count++;
        }

        Console.WriteLine(count);
    }

    static bool IsPrimeNumber(int number)
    {
        if (number == 1) return false;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}