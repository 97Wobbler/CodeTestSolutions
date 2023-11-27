int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int a = numbers[0];
int b = numbers[1];
int c = numbers[2];

int d = numbers[3];
int e = numbers[4];
int f = numbers[5];

int x = (c * e - b * f) / (a * e - b * d);
int y = (c * d - a * f) / (b * d - a * e);

Console.WriteLine(x + " " + y);