using FluentAssertions;
using LeetCode.DataStructures;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest.Easy
{
	public class MergeTwoListsTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var l1 = ListNode.GetListNode(new int[] { 1, 2, 4 });
			var l2 = ListNode.GetListNode(new int[] { 1, 3, 4 });
			var r1 = solution.MergeTwoLists(l1, l2);
			var exp1 = ListNode.GetListNode(new int[] { 1, 1, 2, 3, 4, 4 });
			r1.Should().BeEquivalentTo(exp1);

			var l3 = ListNode.GetListNode(new int[] {});
			var l4 = ListNode.GetListNode(new int[] {});
			var r2 = solution.MergeTwoLists(l3, l4);
			var exp2 = ListNode.GetListNode(new int[] {});
			r2.Should().BeEquivalentTo(exp2);

			var l5 = ListNode.GetListNode(new int[] { });
			var l6 = ListNode.GetListNode(new int[] { 1 });
			var r3 = solution.MergeTwoLists(l5, l6);
			var exp3 = ListNode.GetListNode(new int[] { 1 });
			r3.Should().BeEquivalentTo(exp3);
		}

	}
}
