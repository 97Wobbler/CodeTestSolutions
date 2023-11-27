int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = numbers[0];
int M = numbers[1];

int result = 0;
int diff = M;

int[] cards = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int cardCount = cards.Length;

for (int i = 0; i < cardCount - 2; i++)
{
    for (int j = i + 1; j < cardCount - 1; j++)
    {
        for (int k = j + 1; k < cardCount; k++)
        {
            int newResult = cards[i] + cards[j] + cards[k];

            if (newResult > M)
            {
                continue;
            }
            else if (newResult == M)
            {
                Console.WriteLine(M);
                return;
            }
            else
            {
                int newDiff = M - newResult;
                if (newDiff < diff)
                {
                    result = newResult;
                    diff = newDiff;
                }
            }
        }
    }
}

Console.WriteLine(result);