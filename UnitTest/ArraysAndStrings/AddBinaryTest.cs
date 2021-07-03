﻿using FluentAssertions;
using LeetCode.ArraysAndStrings;
using Xunit;

namespace UnitTest.ArraysAndStrings
{
	public class AddBinaryTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var num1 = "11";
			var num2 = "1";
			var num3 = "1010";
			var num4 = "1011";
			var num5 = "0";
			solution.AddBinary(num1, num2).Should().Be("100");
			solution.AddBinary(num3, num4).Should().Be("10101");
			solution.AddBinary(num5, num5).Should().Be("0");

		}
	}
}
