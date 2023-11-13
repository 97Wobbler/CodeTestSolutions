int[] pointA = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] pointB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] pointC = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int x = pointA[0] ^ pointB[0] ^ pointC[0];
int y = pointA[1] ^ pointB[1] ^ pointC[1];

Console.WriteLine(x + " " + y);