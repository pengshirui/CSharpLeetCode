using FluentAssertions;
using LeetCode.ArraysAndStrings;
using Xunit;

namespace UnitTest.ArraysAndStrings
{
	public class GroupAnagramsTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var s1 = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
			var s2 = new string[] { "" };
			var s3 = new string[] { "a" };
			var s4 = new string[] { };
			solution.GroupAnagrams(s1).Should().HaveCount(3);
			solution.GroupAnagrams(s2).Should().HaveCount(1);
			solution.GroupAnagrams(s3).Should().HaveCount(1);
			solution.GroupAnagrams(s4).Should().HaveCount(0);

		}
	}
}
