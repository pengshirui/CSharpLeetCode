using FluentAssertions;
using LeetCode.Medium;
using Xunit;

namespace UnitTest.Medium
{
	public class LengthOfLongestSubstringTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1() 
		{
			var s1 = "abcabcbb";
			var s2 = "bbbbb";
			var s3 = "pwwkew";
			var s4 = "";
			var s5 = "a";
			var s6 = "                    ";
			solution.LengthOfLongestSubstring(s1).Should().Be(3);
			solution.LengthOfLongestSubstring(s2).Should().Be(1);
			solution.LengthOfLongestSubstring(s3).Should().Be(3);
			solution.LengthOfLongestSubstring(s4).Should().Be(0);
			solution.LengthOfLongestSubstring(s5).Should().Be(1);
			solution.LengthOfLongestSubstring(s6).Should().Be(1);

		}
	}
}
