namespace UnitTest.Medium
{
    using FluentAssertions;
    using LeetCode.Medium;
    using Xunit;

    public class NextClosestTimeTest
    {
        [Fact]
        public void Test1()
        {
            var nextClosestTime = new Solution();

            var res1 = nextClosestTime.NextClosestTime("01:01");
            var res2 = nextClosestTime.NextClosestTime("00:00");
            var res3 = nextClosestTime.NextClosestTime("01:10");
            var res4 = nextClosestTime.NextClosestTime("23:59");
            var res5 = nextClosestTime.NextClosestTime("23:52");

            res1.Should().Be("01:10");
            res2.Should().Be("00:00");
            res3.Should().Be("01:11");
            res4.Should().Be("22:22");
            res5.Should().Be("23:53");

        }
    }
}
