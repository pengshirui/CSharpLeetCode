using System.Collections.Generic;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            var kv = new Dictionary<int, int>
            {
                { 0, 1 },
            };
            var sum = 0;
            var count = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                var diff = sum - k;
                if (kv.TryGetValue(diff, out var v2))
                {
                    count += v2;
                }
                if (kv.TryGetValue(sum, out var v1))
                {
                    kv[sum] = v1 + 1;
                }
                else
                {
                    kv.Add(sum, 1);
                }
            }

            return count;
        }
    }
}
