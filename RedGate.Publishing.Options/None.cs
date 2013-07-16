using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RedGate.Publishing.Options
{
    public class None<T> : IOption<T>
    {
        public void UseValue(Action<T> func)
        {
        }

        public IOption<TResult> Map<TResult>(Func<T, TResult> func)
        {
            return new None<TResult>();
        }

        public T ValueOrElse(T value)
        {
            return value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Enumerable.Empty<T>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
