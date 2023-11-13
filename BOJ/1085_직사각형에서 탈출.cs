using System.Linq;

string[] inputs = Console.ReadLine().Split();

int x = int.Parse(inputs[0]);
int y = int.Parse(inputs[1]);
int w = int.Parse(inputs[2]);
int h = int.Parse(inputs[3]);

int[] distances = {x, w - x, y, h - y};
Console.WriteLine(distances.Min());