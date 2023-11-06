### `string[]`의 각 값을 `int`로 파싱하여 `int[]`로 변환하는 예시

```csharp
using System;
using System.Linq;

namespace Choi {
    class Program {
        static void Main() {
            string input = Console.ReadLine();  // 예를 들어, "1 2 3 4 5"
            string[] stringArray = input.Split(' ');

            // LINQ를 사용하여 각 string을 int로 변환
            int[] intArray = stringArray.Select(int.Parse).ToArray();

            // 이제 intArray는 int 형식의 배열입니다.
        }
    }
}
```

이 코드에서 `System.Linq` 네임스페이스의 `Select` 메서드를 사용하여 각 문자열을 `int`로 변환하고, `ToArray()` 메서드를 사용하여 그 결과를 `int[]`로 만듭니다. 이렇게 하면 한 줄로 간단하게 문자열 배열을 정수 배열로 변환할 수 있습니다.