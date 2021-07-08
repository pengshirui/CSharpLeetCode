using LeetCode.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public partial class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            var fast = head;
            var slow = head;

            while(fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            return slow;
        }
    }
}
