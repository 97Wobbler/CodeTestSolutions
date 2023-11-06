List<string> inputs = new List<string>();

string input = Console.ReadLine();

while (input != "" && input != null) {
    inputs.Add(input);
    input = Console.ReadLine();
}

string result = string.Join("\n", inputs);
Console.WriteLine(result);