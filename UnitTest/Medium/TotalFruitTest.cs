using FluentAssertions;
using LeetCode.Medium;
using Xunit;

namespace UnitTest.Medium
{

    public class TotalFruitTest
    {
        [Fact]
        public void Test1()
        {
            var arr = new int[]{ 0, 1, 2, 2 };
            var totalFruit = new Solution();

            var res = totalFruit.TotalFruit(arr);

            res.Should().Be(3);
        }
    }
}
