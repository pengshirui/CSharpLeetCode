using FluentAssertions;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest.Medium
{
	public class ThreeSumTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var nums1 = new int[] { -1, 0, 1, 2, -1, -4 };
			var nums2 = new int[] { };
			var nums3 = new int[] { 0 };
			solution.ThreeSum(nums1).Should().HaveCount(2);
			solution.ThreeSum(nums2).Should().HaveCount(0);
			solution.ThreeSum(nums3).Should().HaveCount(0);

		}
	}
}