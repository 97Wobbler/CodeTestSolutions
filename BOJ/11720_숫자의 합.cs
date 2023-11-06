int n = Convert.ToInt32(Console.ReadLine());

string numbers = Console.ReadLine();

int sum = 0;

foreach (char c in numbers) {
    sum += (int)char.GetNumericValue(c);
}

Console.WriteLine(sum);