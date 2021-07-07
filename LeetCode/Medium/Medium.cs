using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        void Swap(int[] nums, int i, int j)
        {
            var t = nums[i];
            nums[i] = nums[j];
            nums[j] = t;
        }
    }
}
