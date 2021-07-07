using FluentAssertions;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest.Medium
{
	public class MyAtoiTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var s1 = "42";
			var s2 = "   -42";
			var s3 = "4193 with words";
			var s4 = "words and 987";
			var s5 = "-91283472332";
			var s6 = "                    ";
			var s7 = int.MaxValue * -1;
			solution.MyAtoi(s1).Should().Be(42);
			solution.MyAtoi(s2).Should().Be(-42);
			solution.MyAtoi(s3).Should().Be(4193);
			solution.MyAtoi(s4).Should().Be(0);
			solution.MyAtoi(s5).Should().Be(-2147483648);
			solution.MyAtoi(s6).Should().Be(0);
			solution.MyAtoi($"{s7}").Should().Be(-2147483647);

		}
	}
}
