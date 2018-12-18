/// <summary>
/// https://leetcode.com/problems/two-sum
/// </summary>
namespace LeetCode.Easy
{
    using System.Collections.Generic;

    public partial class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (dictionary.TryGetValue(nums[i], out var value))
                {
                    return new int[] { value, i };
                }

                dictionary[target - nums[i]] =  i;
            }

            return new int[0];
        }
    }
}
