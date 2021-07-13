using FluentAssertions;
using LeetCode.Easy;
using Xunit;

namespace UnitTest.Easy
{
	public class MoveZeroesTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var nums1 = new int[] { 1, 2, 0, 0, 3, 4, 5 };
			solution.MoveZeroes(nums1);
			var r1 = new int[] { 1, 2, 3, 4, 5, 0, 0 };
			nums1.Should().BeEquivalentTo(r1);

			var nums2 = new int[] { 1, 0 };
			solution.MoveZeroes(nums2);
			var r2 = new int[] { 1, 0 };
			nums2.Should().BeEquivalentTo(r2);

			var nums3 = new int[] { 0 };
			solution.MoveZeroes(nums3);
			var r3 = new int[] { 0 };
			nums3.Should().BeEquivalentTo(r3);

			var nums4 = new int[] { 0, 1 };
			solution.MoveZeroes(nums3);
			var r4 = new int[] { 0, 1 };
			nums4.Should().BeEquivalentTo(r4);
		}
	}
}
