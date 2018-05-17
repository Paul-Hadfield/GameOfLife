using GameOfLife.Rules;
using Xunit;

namespace ConsoleTests.Rules
{
    public class Rule1Tests
    {
        [Fact]
        public void IsMatchedWithNoLiveNeighbours()
        {
            Assert.True(new Rule1().IsMatched(true, 0));
        }

        [Fact]
        public void IsMatchedWith1LiveNeighbour()
        {
            Assert.True(new Rule1().IsMatched(true, 1));
        }

        [Fact]
        public void IsNotMatchedWith2LiveNeighbour()
        {
            Assert.False(new Rule1().IsMatched(true, 2));
        }

        [Fact]
        public void IsNotMatchedWithDead()
        {
            Assert.False(new Rule1().IsMatched(false, 0));
        }
    }
}
