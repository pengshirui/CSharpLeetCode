using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public void NextPermutation(int[] nums)
        {
            // starts with second last index
            var i = nums.Length - 2;
            while (i >= 0 && nums[i + 1] <= nums[i])
            {
                i--;
            }
            // i stops at index before the peek value
            if (i >= 0)
            {
                var j = nums.Length - 1;
                while (nums[j] <= nums[i])
                {
                    // find index just greater than i
                    j--;
                }
                Swap(nums, i, j);
            }
            // reverse from the peek;
            Reverse(nums, i + 1);
        }

        private void Reverse(int[] nums, int startIndex) 
        {
            var endIndex = nums.Length - 1;
            while (startIndex < endIndex)
            {
                Swap(nums, startIndex++, endIndex--);
            }

        }

    }
}
