/// <summary>
/// https://leetcode.com/problems/next-closest-time/
/// </summary>

using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public string NextClosestTime(string time)
        {
            var parts = time.Split(":");
            int.TryParse(parts[0], out var hour);
            int.TryParse(parts[1], out var min);

            var nums = new List<int>
            {
                parts[0][0] - '0',
                parts[0][1] - '0',
                parts[1][0] - '0',
                parts[1][1] - '0'
            };

            nums.Sort();

            var totalTime = 60 * hour + min;
            var elapse = 24 * 60;

            foreach(var h1 in nums) foreach(var h2 in nums) if (h1 * 10 + h2 < 24)
            {
                foreach(var m1 in nums) foreach(var m2 in nums) if (m1 * 10 + m2 < 59)
                {
                    var cur = 60 * (h1 * 10 + h2) + (m1 * 10 + m2);
                                    
                    if (cur > totalTime)
                    {
                        elapse = Math.Min(elapse, cur - totalTime);
                    }
                    else if (cur < totalTime)
                    {
                        elapse = Math.Min(elapse, cur - totalTime + 24 * 60);
                    }
                }
            }

            var result = elapse + totalTime;
            return TimeSpan.FromMinutes(result).ToString("hh':'mm");
        }
    }
}
