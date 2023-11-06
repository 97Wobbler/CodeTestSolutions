`var` 키워드는 C#에서 "암시적 타입 지역 변수"를 선언할 때 사용됩니다. 사용할 때 `var`를 사용하여 변수를 선언하면, 컴파일러가 변수의 타입을 초기화하는 식으로부터 추론하게 합니다. 이렇게 함으로써, 변수의 타입을 명시적으로 쓰지 않아도 됩니다, 이는 코드를 더 간결하게 작성할 수 있게 해주며, 특히 LINQ 쿼리 같은 복잡한 타입의 경우 유용합니다.

예를 들어, 다음 두 변수 선언은 동등합니다:

```csharp
Dictionary<string, int> countDictionary = new Dictionary<string, int>();
var countDictionary = new Dictionary<string, int>();
```

두 경우 모두 `countDictionary`는 `Dictionary<string, int>` 타입의 객체를 참조하게 됩니다. `var`를 사용하면 초기화 식이 명확할 때 타입 선언을 생략할 수 있어서 코드가 더 깔끔해지고 타입 변경이 있을 때 수정하기 쉬워집니다. 하지만 `var` 키워드를 사용할 때는 변수를 초기화하는 부분이 같은 라인에 있어야 하며, 초기화 없이는 `var`를 사용할 수 없습니다.

`var` 키워드를 사용할 때는 선언하는 변수의 타입이 초기화 식을 통해 명확해야 하며, 변수 선언 시에 초기화가 반드시 이루어져야 합니다. 그리고 실행 시간에 이 타입이 변경될 수 없습니다; 즉, 선언된 변수의 타입은 동적으로 변경되지 않습니다.

이런 조건들을 충족시키면, `var`를 사용하여 코드를 더 간결하게 만들 수 있습니다. 예를 들면, 다음과 같은 경우에 `var`를 사용하면 편리합니다:

```csharp
var number = 42; // int로 추론
var name = "Alice"; // string으로 추론
var person = new Person(); // Person 타입으로 추론
var numbers = new int[] {1, 2, 3}; // int[] 타입으로 추론
```

여기서 컴파일러는 `number`가 `int`, `name`이 `string`, `person`이 `Person` 클래스의 인스턴스, `numbers`가 `int` 배열인 것을 초기화 식으로부터 알 수 있습니다. 그래서 이후 코드에서 해당 변수들의 타입에 맞는 모든 메서드나 프로퍼티를 사용할 수 있게 됩니다.