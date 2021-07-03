using FluentAssertions;
using LeetCode.ArraysAndStrings;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest.ArraysAndStrings
{
	public class NextPermutationTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var nums1 = new int[] { 1, 2, 3 };
			var nums2 = new int[] { 3, 2, 1 };
			var nums3 = new int[] { };
			var nums4 = new int[] { 1, 1, 5 };
			var nums5 = new int[] { 1 };
			solution.NextPermutation(nums1);
			solution.NextPermutation(nums2);
			solution.NextPermutation(nums3);
			solution.NextPermutation(nums4);
			solution.NextPermutation(nums5);

			nums1.ToString().Should().Be(new int[] { 1, 3, 2 }.ToString());
			nums2.ToString().Should().Be(new int[] { 1, 2, 3 }.ToString());
			nums3.ToString().Should().Be(new int[] { }.ToString());
			nums4.ToString().Should().Be(new int[] { 1, 5, 1 }.ToString());
			nums5.ToString().Should().Be(new int[] { 1 }.ToString());

		}
	}
}
