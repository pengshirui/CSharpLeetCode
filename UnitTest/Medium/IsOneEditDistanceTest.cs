using FluentAssertions;
using LeetCode.Medium;
using Xunit;

namespace UnitTest.Medium
{
    public class IsOneEditDistanceTest
    {
        Solution solution = new Solution();

        [Fact]
        public void Test1()
        {
            var s1 = "ab";
            var t1 = "acb";
            var s2 = "";
            var t2 = "";
            var s3 = "a";
            var t3 = "";
            var s4 = "";
            var t4 = "A";
            var s5 = "a";
            var t5 = "ac";

            solution.IsOneEditDistance(s1, t1).Should().BeTrue();
            solution.IsOneEditDistance(s2, t2).Should().BeFalse();
            solution.IsOneEditDistance(s3, t3).Should().BeTrue();
            solution.IsOneEditDistance(s4, t4).Should().BeTrue();
            solution.IsOneEditDistance(s5, t5).Should().BeTrue();
        }
    }
}
