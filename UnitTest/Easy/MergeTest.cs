using FluentAssertions;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest.Easy
{
    public class MergeTest
	{

		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
			var nums2 = new int[] { 2, 5, 6 };
			var nums3 = new int[] { 1 };
			var nums4 = new int[] { };
			var nums5 = new int[] { 0 };
			var nums6 = new int[] { 1 };
			solution.Merge(nums1, 3, nums2, 3); 
			nums1.Should().Equal(new int[] { 1, 2, 2, 3, 5, 6 });
			solution.Merge(nums3, 1, nums4, 0);
			nums3.Should().Equal(new int[] { 1 });
			solution.Merge(nums5, 0, nums6, 1);
			nums5.Should().Equal(new int[] { 1 });

		}
	}
}
