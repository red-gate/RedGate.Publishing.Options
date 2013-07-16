using System;
using System.Collections.Generic;

namespace RedGate.Publishing.Options
{
    public interface IOption<T> : IEnumerable<T>
    {
        void UseValue(Action<T> func);
        IOption<TResult> Map<TResult>(Func<T, TResult> func);
        T ValueOrElse(T value);
    }
}
