int[] array = new int[5];
int sum = 0;

for (int i = 0; i < 5; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    sum += array[i];
}

Array.Sort(array);

Console.WriteLine(sum / 5);
Console.WriteLine(array[2]);