using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] elementsToCount = { "dz=", "c=", "c-", "d-", "lj", "nj", "s=", "z=" };
        // Array.Sort(elementsToCount, (a, b) => b.Length.CompareTo(a.Length));

        string testString = Console.ReadLine();

        foreach (string element in elementsToCount)
        {
            while (testString.Contains(element))
            {
                testString = testString.(element, "*");
            }
        }

        Console.WriteLine(testString.Length);
    }
}