# RedGate.Publishing.Options

## Creating an option

```csharp
Option.Some(4);
Option.None<int>();

Option.FromNullable("42") == Option.Some("42") // True
string value = null;
Option.FromNullable(value) == Option.None<string>(); // True

## Methods on `IOption<T>`

### `IOption<TResult> Map<TResult>(Func<T, TResult> func)`

### `T ValueOrElse(T value)`

Returns the contained value if an instance of `Some`,
otherwise return `value`.
