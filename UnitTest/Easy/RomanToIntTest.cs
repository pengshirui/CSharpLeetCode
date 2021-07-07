using FluentAssertions;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest.Easy
{
	public class RomanToIntTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var s1 = "III";
			var s2 = "IV";
			var s3 = "IX";
			var s4 = "LVIII";
			var s5 = "MCMXCIV";
			var s6 = "";
			solution.RomanToInt(s1).Should().Be(3);
			solution.RomanToInt(s2).Should().Be(4);
			solution.RomanToInt(s3).Should().Be(9);
			solution.RomanToInt(s4).Should().Be(58);
			solution.RomanToInt(s5).Should().Be(1994);
			solution.RomanToInt(s6).Should().Be(0);

		}
	}
}
