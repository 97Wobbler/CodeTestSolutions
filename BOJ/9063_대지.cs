using System.Linq;

int N = int.Parse(Console.ReadLine());

List<int> x = new List<int>();
List<int> y = new List<int>();

for (int i = 0; i < N; i++)
{
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    x.Add(numbers[0]);
    y.Add(numbers[1]);
}

int xMin = x.Min();
int xMax = x.Max();
int yMin = y.Min();
int yMax = y.Max();

Console.WriteLine((yMax - yMin) * (xMax - xMin));