int X = int.Parse(Console.ReadLine());

int diagonalLineNumber = 0;
int diagonalLineLength = 1;

while (X > diagonalLineLength)
{
    X -= diagonalLineLength;
    diagonalLineNumber++;
    diagonalLineLength++;
}

int diagonalElementIndex = X - 1;

int numerator;
int denominator;

if (diagonalLineNumber % 2 == 0)
{
    int x = 0;
    int y = diagonalLineNumber;

    for (int i = 0; i < diagonalElementIndex; i++)
    {
        x++;
        y--;
    }

    numerator = y + 1;
    denominator = x + 1;
}
else
{

    int x = diagonalLineNumber;
    int y = 0;

    for (int i = 0; i < diagonalElementIndex; i++)
    {
        x--;
        y++;
    }

    numerator = y + 1;
    denominator = x + 1;
}

Console.WriteLine(numerator + "/" + denominator);