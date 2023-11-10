class Choi
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();

        string N = inputs[0];
        int B = int.Parse(inputs[1]);

        int result = ConvertToDecimalNumber(N, B);

        Console.WriteLine(result);
    }

    static int ConvertToDecimalNumber(string input, int baseNumber)
    {
        int output = 0;
        int power = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            int digit = CharToNumber(input[i]);

            output += digit * (int)Math.Pow(baseNumber, power);
            power++;
        }

        return output;
    }

    static int CharToNumber(char digit)
    {
        if (char.IsDigit(digit))
        {
            return int.Parse(digit.ToString());
        }
        else
        {
            return char.ToUpper(digit) - 'A' + 10;
        }
    }
}