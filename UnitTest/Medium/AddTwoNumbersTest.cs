using FluentAssertions;
using LeetCode.DataStructures;
using LeetCode.Medium;
using Xunit;

namespace UnitTest.Medium
{
    public class AddTwoNumbersTest
    {
        Solution solution = new Solution();

        [Fact]
        public void Test1()
        {
            var l1 = ListNode.GetListNode(2, 4, 3);
            var l2 = ListNode.GetListNode(5, 6, 4);
            var l3 = ListNode.GetListNode(0);
            var l4 = ListNode.GetListNode(0);
            var l5 = ListNode.GetListNode(9, 9, 9, 9, 9, 9, 9);
            var l6 = ListNode.GetListNode(9, 9, 9, 9);
            var r1 = ListNode.GetListNode(7, 0, 8);
            var r2 = ListNode.GetListNode(0);
            var r3 = ListNode.GetListNode(8, 9, 9, 9, 0, 0, 0, 1);
            /*
            solution.AddTwoNumbers(l1, l2).Should().BeEquivalentTo(r1);
            solution.AddTwoNumbers(l3, l4).Should().BeEquivalentTo(r2);
            solution.AddTwoNumbers(l5, l6).Should().BeEquivalentTo(r3);
            */
            solution.AddTwoNumbersRecursive(l1, l2).Should().BeEquivalentTo(r1);
            solution.AddTwoNumbersRecursive(l3, l4).Should().BeEquivalentTo(r2);
            solution.AddTwoNumbersRecursive(l5, l6).Should().BeEquivalentTo(r3);
        }
    }
}
