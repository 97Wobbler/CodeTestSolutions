int rowCountMax = 5;
int columnCountMax = 15;

char[,] inputs = new char[rowCountMax, columnCountMax];
string result = "";

for (int row = 0; row < rowCountMax; row++)
{
    string currentRow = Console.ReadLine();
    int currentColumnCount = currentRow.Length;

    for (int column = 0; column < currentColumnCount; column++)
    {
        inputs[row, column] = currentRow[column];
    }
}

for (int column = 0; column < columnCountMax; column++)
{
    for (int row = 0; row < rowCountMax; row++)
    {
        if (inputs[row, column] != '\0') result += inputs[row, column];
    }
}

Console.WriteLine(result);