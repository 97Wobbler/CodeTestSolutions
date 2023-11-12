// N <= 1 → count = 1
// N <= 7 → count = 2
// N <= 19 → count = 3
// N <= 37 → count = 4

int N = int.Parse(Console.ReadLine());
int layerMaxValue = 1;
int layerCount = 1;

while (N > layerMaxValue)
{
    layerMaxValue += layerCount * 6;
    layerCount++;
}

Console.WriteLine(layerCount);