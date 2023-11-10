using System;
using System.Text;

class Choi
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();

        int N = int.Parse(inputs[0]);
        int B = int.Parse(inputs[1]);

        string result = ConvertToDecimnalNumber(N, B);

        Console.WriteLine(result);
    }

    static string ConvertToDecimnalNumber(int number, int baseNumber)
    {
        StringBuilder result = new StringBuilder();

        while (number > 0)
        {
            int remainder = number % baseNumber;
            result.Insert(0, NumberToChar(remainder));
            number /= baseNumber;
        }

        return result.ToString();
    }

    static char NumberToChar(int number)
    {
        if (number < 10)
        {
            return (char)('0' + number);
        }
        else
        {
            return (char)(number - 10 + 'A');
        }
    }
}