using Xunit;

namespace RedGate.Publishing.Options.UnitTests
{
    public class SomeTests
    {
        [Fact]
        public void SomeInstancesAreEqualIfValuesAreEqual()
        {
            Assert.True(Option.Some(42).Equals(Option.Some(42)));
        }

        [Fact]
        public void SomeInstancesAreNotEqualIfValuesAreNotEqual()
        {
            Assert.False(Option.Some(42).Equals(Option.Some(43)));
        }

        [Fact]
        public void SomeInstancesAreNotEqualIfValuesAreOfDifferentTypes()
        {
            Assert.False(Option.Some(42).Equals(Option.Some("42")));
        }

        [Fact]
        public void MapAppliesFunctionToValueWithinSome()
        {
            Assert.Equal(Option.Some(47), Option.Some(42).Map(x => x + 5));
        }

        [Fact]
        public void CanUseMapWithNamedMethod()
        {
            Assert.Equal(Option.Some(47), Option.Some(42).Map(AddFive));
        }

        private int AddFive(int value)
        {
            return value + 5;
        }
    }
}
