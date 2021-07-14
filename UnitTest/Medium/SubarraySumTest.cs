using FluentAssertions;
using LeetCode.Medium;
using Xunit;

namespace UnitTest.Medium
{
    public class SubarraySumTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var nums1 = new int[10];
			solution.SubarraySum(nums1, 0).Should().Be(55);

			var nums2 = new int[100];
			solution.SubarraySum(nums2, 0).Should().Be(5050);

		}
	}
}