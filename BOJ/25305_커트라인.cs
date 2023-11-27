int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = numbers[0];
int k = numbers[1];

int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(array);
Console.WriteLine(array[N - k]);