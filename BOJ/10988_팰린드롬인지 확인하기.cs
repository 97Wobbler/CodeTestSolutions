using System.Linq;

string input = Console.ReadLine();
string reversed = new String(input.Reverse().ToArray());

if (input == reversed) {
    Console.WriteLine(1);
} else {
    Console.WriteLine(0);
}