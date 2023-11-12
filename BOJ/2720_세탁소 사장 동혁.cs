using System.Text;

class PrintCoinsCount
{
    static int quaterValue = 25;
    static int dimeValue = 10;
    static int nickelValue = 5;
    static int pennyValue = 1;

    static void Main()
    {
        int testCaseCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCaseCount; i++)
        {
            int amountInCents = int.Parse(Console.ReadLine());
            GetCoinsCount(amountInCents);
        }
    }

    static void GetCoinsCount(int amountInCents)
    {
        List<string> array = new List<string>();

        array.Add((amountInCents / quaterValue).ToString());
        amountInCents = amountInCents % quaterValue;

        array.Add((amountInCents / dimeValue).ToString());
        amountInCents = amountInCents % dimeValue;

        array.Add((amountInCents / nickelValue).ToString());
        amountInCents = amountInCents % nickelValue;

        array.Add(amountInCents.ToString());

        Console.WriteLine(string.Join(" ", array));
    }
}