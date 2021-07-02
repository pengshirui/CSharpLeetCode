using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.ArraysAndStrings
{
    public partial class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums?.Length < 2)
            {
                return result.ToList();
            }
            // O(nlogn)
            Array.Sort(nums);
            for (var i = 0; i < nums.Length && nums[i] <= 0; i++)
            {
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    var low = i + 1;
                    var high = nums.Length - 1;
                    while (low < high)
                    {
                        var sum = nums[low] + nums[high] + nums[i];
                        if (sum < 0)
                        {
                            low++;
                        }
                        else if (sum > 0)
                        {
                            high--;
                        }
                        else
                        {
                            result.Add(new List<int> { nums[low++], nums[high--], nums[i] });
                            while (low < high && nums[low] == nums[low - 1])
                            {
                                low++;
                            }
                        }
                    }
                }
            }
                
            return result;
        }
    }
}
