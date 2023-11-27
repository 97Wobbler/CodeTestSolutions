int N = int.Parse(Console.ReadLine());

int count = 0;

int number = 0;

while (count < N)
{
    number++;
    if (number.ToString().Contains("666")) count++;
}

Console.WriteLine(number);


// 아래는 시간초과 판정을 받은 풀이

// int N = int.Parse(Console.ReadLine());

// List<int> list = new List<int> { 666 };

// while (list.Count < N)
// {
//     List<string> newList = new List<string>();

//     for (int j = 0; j < list.Count; j++)
//     {
//         string element = list[j].ToString();

//         for (int k = 0; k < 9; k++)
//         {
//             newList.Append(k.ToString() + element);
//             newList.Append(element + k.ToString());
//         }
//     }

//     List<int> newIntList = newList.ConvertAll(x => int.Parse(x));

//     list.AddRange(newIntList);
//     list = list.Distinct().OrderBy(x => x).ToList();
// }

// Console.WriteLine(list[N]);