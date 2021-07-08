using LeetCode.DataStructures;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var dummyHead = new ListNode();
            var current = new ListNode();
            dummyHead.next = current;
            var prev = dummyHead;

            while (l1 != null && l2 != null)
            {
                var sum = l1.val + l2.val + current.val;
                var carry = sum / 10;
                var remainder = sum % 10;

                current.val = remainder;
                current.next = new ListNode(carry);
                prev = current;
                current = current.next;
                l1 = l1.next; 
                l2 = l2.next;
            }

            while (l1 != null)
            {
                var sum = l1.val + current.val;
                var carry = sum / 10;
                var remainder = sum % 10;

                current.val = remainder;
                current.next = new ListNode(carry);
                prev = current;
                current = current.next;
                l1 = l1.next;
            }

            while (l2 != null)
            {
                var sum = l2.val + current.val;
                var carry = sum / 10;
                var remainder = sum % 10;

                current.val = remainder;
                current.next = new ListNode(carry);
                prev = current;
                current = current.next;
                l2 = l2.next;
            }
            
            if (current.val == 0)
            {
                prev.next = null;
            }

            return dummyHead.next;
        }

        public ListNode AddTwoNumbersRecursive(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            var sum = (l1?.val ?? 0) + (l2?.val ?? 0);
            var carry = sum / 10;
            var remainder = sum % 10;

            l1 = l1?.next;
            l2 = l2?.next;

            if (carry > 0)
            {
                if (l1 == null)
                {
                    l1 = new ListNode(carry);
                }
                else
                {
                    l1.val += carry;
                }
            }

            return new ListNode(remainder, AddTwoNumbersRecursive(l1, l2));
        }
    }
}
