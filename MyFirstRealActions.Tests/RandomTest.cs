using FluentAssertions;

namespace MyFirstRealActions.Tests
{
    public class RandomTest
    {
        [Fact]
        public void Test1()
        {
            string expected = "Hello world";

            expected.Should().BeEquivalentTo(expected);
        }
    }
}
