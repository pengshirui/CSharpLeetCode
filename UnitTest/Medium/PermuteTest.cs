using FluentAssertions;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest.Medium
{
	public class PermuteTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var nums1 = new int[] { 1, 2, 3 };
			var nums2 = new int[] { 1, 2 };
			var nums3 = new int[] { 1 };
			solution.Permute(nums1).Should().HaveCount(6);
			solution.Permute(nums2).Should().HaveCount(2);
			solution.Permute(nums3).Should().HaveCount(1);
		}
	}
}
