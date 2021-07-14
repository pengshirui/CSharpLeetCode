using FluentAssertions;
using LeetCode.Medium;
using Xunit;

namespace UnitTest.Medium
{
	public class LengthOfLongestSubstringKDistinctTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var s1 = "abcabcbb";
			var s2 = "bbbbb";
			var s3 = "eceba";
			var s4 = "aa";
			var s5 = "a";
			solution.LengthOfLongestSubstringKDistinct(s1, 1).Should().Be(2);
			solution.LengthOfLongestSubstringKDistinct(s2, 1).Should().Be(5);
			solution.LengthOfLongestSubstringKDistinct(s3, 2).Should().Be(3);
			solution.LengthOfLongestSubstringKDistinct(s4, 1).Should().Be(2);
			solution.LengthOfLongestSubstringKDistinct(s5, 2).Should().Be(1);

		}
	}
}
