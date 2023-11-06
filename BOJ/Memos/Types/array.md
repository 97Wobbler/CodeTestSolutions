### 배열의 선언
C#에서 배열을 선언하는 기본적인 방법은 다음과 같습니다:

```csharp
int n = 10; // 예를 들어 배열의 크기를 10으로 하겠다는 가정 하에
int[] array = new int[n];
```

위 코드에서 `n`은 배열에 포함될 요소의 수를 나타냅니다. 배열의 각 요소는 기본적으로 `int`형 배열의 경우 0으로 초기화됩니다.

배열을 초기화하고 동시에 특정 값으로 채우고 싶다면, 다음과 같이 할 수 있습니다:

```csharp
int n = 10; // 배열의 크기를 10으로 설정
int[] array = Enumerable.Repeat(0, n).ToArray(); // 모든 요소를 0으로 초기화
```

이 경우 `Enumerable.Repeat(0, n)`은 `0`을 `n`번 반복하는 시퀀스를 생성하고, `ToArray()`를 사용하여 그 시퀀스를 배열로 변환합니다. 여기서 `0` 대신 다른 값을 사용하여 초기화 값을 지정할 수도 있습니다.

### 배열의 선언 - 증가하는 번호 넣기
C#에서는 Enumerable.Range를 사용하여 간단하게 일정 범위의 숫자로 구성된 배열을 만들 수 있습니다. `Enumerable.Range`는 첫 번째 매개변수로 시작 숫자를, 두 번째 매개변수로 생성할 숫자의 개수를 받습니다. 그 후 `.ToArray()` 메소드를 사용하여 이 범위를 배열로 변환할 수 있습니다.

예를 들어, 0부터 시작하여 n+1개의 정수(0 이상 n 이하)를 포함하는 배열을 만들고 싶다면 다음과 같이 작성할 수 있습니다:

```csharp
using System;
using System.Linq;

class Program {
    static void Main() {
        int n = 10; // 예시로 10을 사용했습니다.
        int[] array = Enumerable.Range(0, n + 1).ToArray();

        // 배열 출력해보기
        Console.WriteLine(string.Join(", ", array));
    }
}
```

이 코드는 0부터 n까지의 정수를 포함하는 배열을 생성하고 출력합니다. 위 예에서 `n`이 10이므로, 0부터 10까지의 숫자가 포함된 배열이 만들어지고 출력됩니다.



### 반복문의 형태

C#에서 배열에 대한 `for` 반복문을 사용하는 방법은 다양합니다. 가장 기본적인 방법은 다음과 같습니다:

```csharp
int[] array = { 1, 2, 3, 4, 5 };

for (int i = 0; i < array.Length; i++) {
    Console.WriteLine(array[i]);
}
```

이 코드는 배열 `array`의 모든 요소를 순회하면서 그 값을 출력합니다.

또한 `foreach` 문을 사용하여 배열을 더 쉽게 순회할 수 있습니다:

```csharp
int[] array = { 1, 2, 3, 4, 5 };

foreach (int item in array) {
    Console.WriteLine(item);
}
```

`foreach` 문은 배열의 모든 요소를 순서대로 변수 `item`에 할당하고 루프 내의 코드를 실행합니다. 이 방법은 배열의 인덱스를 직접 관리할 필요가 없어서 코드가 더 간결해집니다.


### Reverse 메서드

```csharp
Array.Reverse(myArray, 1, 3); // 배열의 일부분(1~3번 인덱스) 뒤집기
```