string[] inputs = Console.ReadLine().Split();
int A = int.Parse(inputs[0]);
int B = int.Parse(inputs[1]);
int V = int.Parse(inputs[2]);

int heightPerDay = A - B;
double day = (double)(V - B) / (double)heightPerDay;
double result = Math.Ceiling(day);

Console.WriteLine(result);