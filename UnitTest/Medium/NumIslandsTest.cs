using FluentAssertions;
using LeetCode.Medium;
using Xunit;

namespace UnitTest.Medium
{

    public class NumIslandsTest
    {
        [Fact]
        public void Test1()
        {
            var grid1 = new char[,]{ { '1', '0', '0' }, { '1', '1', '0' }, { '0', '0', '1' } };
            var grid2 = new char[,] { { '1', '1', '0', '0', '0' }, { '1', '1', '0', '0', '0' },{ '0', '0', '1', '0', '0' },{ '0', '0', '0', '1', '1' } };

            var numberOfIslands = new Solution();

            var num1 = numberOfIslands.NumIslands(grid1);
            var num2 = numberOfIslands.NumIslands(grid2);

            num1.Should().Equals(2);
            num2.Should().Equals(2);
        }
    }
}
