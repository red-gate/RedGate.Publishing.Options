using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RedGate.Publishing.Options
{
    public class Some<T> : IOption<T>
    {
        private readonly T m_Value;

        public Some(T value)
        {
            m_Value = value;
        }

        public void UseValue(Action<T> func)
        {
            func(m_Value);
        }

        public IOption<TResult> Map<TResult>(Func<T, TResult> func)
        {
            return new Some<TResult>(func(m_Value));
        }

        public T ValueOrElse(T value)
        {
            return m_Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Enumerable.Repeat(m_Value, 1).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        protected bool Equals(Some<T> other)
        {
            return EqualityComparer<T>.Default.Equals(m_Value, other.m_Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Some<T>) obj);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<T>.Default.GetHashCode(m_Value);
        }
    }
}
