namespace RedGate.Publishing.Options
{
    public class Option
    {
        public static IOption<T> Some<T>(T value)
        {
            return new Some<T>(value);
        }

        public static IOption<T> None<T>()
        {
            return new None<T>();
        }

        public static IOption<T> FromNullable<T>(T value) where T : class
        {
            return value == null ? None<T>() : Some(value);
        }
    }
}
