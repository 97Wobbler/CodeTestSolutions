using System.Linq;

class Choi
{
    static void Main()
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        List<int> primeNumbers = new List<int>();

        for (int i = M; i <= N; i++)
        {
            if (IsPrimeNumber(i)) primeNumbers.Add(i);
        }

        if (primeNumbers.Count <= 0)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(primeNumbers.Sum());
            Console.WriteLine(primeNumbers.Min());
        }
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