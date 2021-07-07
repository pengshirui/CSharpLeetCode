using FluentAssertions;
using LeetCode.Easy;
using Xunit;

namespace UnitTest.Easy
{
    public class IsPalindromeTest
	{

		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var str1 = "A man, a plan, a canal: Panama";
			var str2 = "race a car";
			var str3 = "                  ";
			var str4 = "aabbaa";

			solution.IsPalindrome(str1).Should().BeTrue();
			solution.IsPalindrome(str2).Should().BeFalse();
			solution.IsPalindrome(str3).Should().BeTrue();
			solution.IsPalindrome(str4).Should().BeTrue();

		}
	}
}
