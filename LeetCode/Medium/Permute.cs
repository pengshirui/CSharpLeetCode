using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();

            Permute(nums, 0, result);

            return result;
        }

        void Permute(int[] nums, int first, IList<IList<int>> result)
        {
            if (first == nums.Length - 1)
            {
                result.Add(new List<int>(nums));
            }
            for (var i = first; i < nums.Length; i++)
            {
                Swap(nums, i, first);
                Permute(nums, first + 1, result);
                Swap(nums, first, i);
            }
        }

        void Swap(int[] nums, int x, int y)
        {
            var tmp = nums[x];
            nums[x] = nums[y];
            nums[y] = tmp;
        }
    }
}
