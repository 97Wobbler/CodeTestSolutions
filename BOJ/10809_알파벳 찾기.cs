using System.Text;

int smallA = 97;
int smallZ = 122;

string input = Console.ReadLine();
StringBuilder stringBuilder = new StringBuilder();

for (int c = smallA; c <= smallZ; c++)
{
    char character = (char)c;
    int index = input.IndexOf(character);

    stringBuilder.Append(index);

    if (c < smallZ)
    {
        stringBuilder.Append(" ");
    }
}

string result = stringBuilder.ToString();
Console.WriteLine(result);