int maxValue = 0;
int maxValueRowNumber = 1;
int maxValueColumnNumber = 1;

for (int row = 0; row < 9; row++)
{
    string[] rowValues = Console.ReadLine().Split();

    for (int column = 0; column < 9; column++)
    {
        int newValue = int.Parse(rowValues[column]);

        if (newValue > maxValue)
        {
            maxValue = newValue;
            maxValueRowNumber = row + 1;
            maxValueColumnNumber = column + 1;
        }
    }
}

Console.WriteLine(maxValue);
Console.WriteLine(maxValueRowNumber + " " + maxValueColumnNumber);