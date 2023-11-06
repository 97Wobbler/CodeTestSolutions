string[] inputs = Console.ReadLine().Split();

string a = inputs[0];
string b = inputs[1];

string reversedA = new String(a.Reverse().ToArray());
string reversedB = new String(b.Reverse().ToArray());

int wrongA = Int32.Parse(reversedA);
int wrongB = Int32.Parse(reversedB);

if (wrongA > wrongB)
{
    Console.WriteLine(wrongA);
}
else
{
    Console.WriteLine(wrongB);
}