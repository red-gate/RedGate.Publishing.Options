# RedGate.Publishing.Options

## Creating an option

```csharp
Option.Some(4);
Option.None<int>();

Option.FromNullable("42") == Option.Some("42") // True
string value = null;
Option.FromNullable(value) == Option.None<string>(); // True
```

## Methods on `IOption<T>`

### `IOption<TResult> Map<TResult>(Func<T, TResult> func)`

If an instance of `Some`,
applies `func` to the contained value,
and returns the result in an new instance of `Some`.
If `None`, returns `None`.

### `void UseValue(Action<T> func)`

If an instance of `Some`,
applies `func` to the contained value.
If `None`, do nothing.

### `T ValueOrElse(T value)`

Returns the contained value if an instance of `Some`,
otherwise returns `value`.

## License

[BSD 2-Clause](http://opensource.org/licenses/BSD-2-Clause)
