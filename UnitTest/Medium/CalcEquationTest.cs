using FluentAssertions;
using LeetCode.Medium;
using Xunit;

namespace UnitTest.Medium
{
    public class CalcEquationTest
    {
        [Fact]
        public void Test1()
        {
            var e = new string[,] { { "a", "b" }, { "b", "c" } };
            var v = new double[] { 2.0, 3.0 };
            var q = new string[,] { { "a", "c" }, { "b", "a" }, { "a", "e" }, { "a", "a" }, { "x", "x" } };
            var calcEquation = new Solution();

            var res = calcEquation.CalcEquation(e, v, q);

            res.Length.Should().Be(5);
            res[0].Should().Be(6.0);
            res[1].Should().Be(0.5);
            res[2].Should().Be(-1.0);
            res[3].Should().Be(1.0);
            res[4].Should().Be(-1.0);
        }

        [Fact]
        public void Test2()
        {
            var e = new string[,] { { "a", "b" }, { "b", "c" } };
            var v = new double[] { 2.0, 3.0 };
            var q = new string[,] { { "a", "c" }, { "b", "c" }, { "a", "e" }, { "a", "a" }, { "x", "x" } };
            var calcEquation = new Solution();

            var res = calcEquation.CalcEquation(e, v, q);

            res.Length.Should().Be(5);
            res[0].Should().Be(6.0);
            res[1].Should().Be(3.0);
            res[2].Should().Be(-1.0);
            res[3].Should().Be(1.0);
            res[4].Should().Be(-1.0);
        }
    }
}
