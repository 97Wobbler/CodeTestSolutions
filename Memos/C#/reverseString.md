```csharp
// string으로 변환하기 위해 Reverse() 후에 ToArray() 그리고 new string으로 감싸야 함
string reversedA = new string(a.Reverse().ToArray());
```