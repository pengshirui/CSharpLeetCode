using FluentAssertions;
using LeetCode.Easy;
using Xunit;

namespace UnitTest.Easy
{
	public class ValidPalindromeTest
	{

		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var str1 = "amanaplanacanalpanama";
			var str2 = "abc";
			var str3 = "aba";
			var str4 = "abca";
			var str5 = "tcaac";
			var str6 = "aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga";

			solution.ValidPalindrome(str1).Should().BeTrue();
			solution.ValidPalindrome(str2).Should().BeFalse();
			solution.ValidPalindrome(str3).Should().BeTrue();
			solution.ValidPalindrome(str4).Should().BeTrue();
			solution.ValidPalindrome(str5).Should().BeTrue();
			solution.ValidPalindrome(str6).Should().BeTrue();

		}
	}
}
