using FluentAssertions;
using LeetCode.ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest.ArraysAndStrings
{
	public class RemoveDuplicatesTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var nums1 = new int[] { 1, 1, 2 };
			var nums2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
			var nums3 = new int[] { };
			var nums4 = new int[] { 1, 2, 3 };
			solution.RemoveDuplicates(nums1).Should().Be(2);
			solution.RemoveDuplicates(nums2).Should().Be(5);
			solution.RemoveDuplicates(nums3).Should().Be(0);
			solution.RemoveDuplicates(nums4).Should().Be(3);
		}
	}
}
