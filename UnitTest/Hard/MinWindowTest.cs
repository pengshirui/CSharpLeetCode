using FluentAssertions;
using LeetCode.Hard;
using Xunit;

namespace UnitTest.Hard
{
    public class MinWindowTest
    {

        Solution solution = new Solution();

        [Fact]
        public void Test1()
        {
            var s1 = "ADOBECODEBANC";
            var t1 = "ABC";
            var s2 = "a";
            var t2 = "a";
            var s3 = "a";
            var t3 = "aa";
            var s4 = "bbaa";
            var t4 = "aba";
            solution.MinWindow(s1, t1).Should().Be("BANC");
            solution.MinWindow(s2, t2).Should().Be("a");
            solution.MinWindow(s3, t3).Should().Be("");
            solution.MinWindow(s4, t4).Should().Be("baa");
        }

    }
}
