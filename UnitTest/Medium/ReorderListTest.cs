using FluentAssertions;
using LeetCode.DataStructures;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest.Medium
{
	public class ReorderListTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var l1 = ListNode.GetListNode(1, 2, 3, 4);
			var r1 = ListNode.GetListNode(1, 4, 2, 3);
			solution.ReorderList(l1);
			l1.Should().BeEquivalentTo(r1);

			var l2 = ListNode.GetListNode(1, 2, 3, 4, 5);
			var r2 = ListNode.GetListNode(1, 5, 2, 4, 3);
			solution.ReorderList(l2);
			l2.Should().BeEquivalentTo(r2);
		}
	}
}
