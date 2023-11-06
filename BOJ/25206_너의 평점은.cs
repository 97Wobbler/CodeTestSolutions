var scoreMap = new Dictionary<string, float> { { "A+", 4.5f }, { "A0", 4.0f }, { "B+", 3.5f }, { "B0", 3.0f }, { "C+", 2.5f }, { "C0", 2.0f }, { "D+", 1.5f }, { "D0", 1.0f }, { "F", 0.0f } };

float numerator = 0;
float denominator = 0;

for (int i = 0; i < 20; ++i)
{
    string input = Console.ReadLine();
    string[] inputs = input.Split();

    if (inputs[2] == "P") continue;

    float credit = float.Parse(inputs[1]);
    float score = scoreMap[inputs[2]];

    numerator += credit * score;
    denominator += credit;
}

float result = numerator / denominator;

Console.WriteLine(result);