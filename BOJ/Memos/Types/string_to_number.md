chat의 GetNumericValue 메서드를 이용한다.

```csharp
string numbers = "123738957284";

int sum = 0;
foreach (char c in numbers) {
    sum += (int)char.GetNumericValue(c);
}

Console.WriteLine(sum);
```