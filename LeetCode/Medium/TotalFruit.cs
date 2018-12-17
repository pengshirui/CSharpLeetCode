/// <summary>
/// https://leetcode.com/problems/fruit-into-baskets
/// </summary>

using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public int TotalFruit(int[] tree)
        {
            int ans = 0;
            // start index
            int i = 0;
            Counter count = new Counter();
            for (int j = 0; j < tree.Length; ++j)
            {
                // Add one to current item type count 
                count.Increament(tree[j], 1);
                // when bucket has more than three items
                while (count.Count >= 3)
                {
                    // remove one from type of start index
                    count.Increament(tree[i], -1);
                    if (count.Get(tree[i]) == 0)
                    {
                        count.Remove(tree[i]);
                    }
                    i++;
                }

                ans = Math.Max(ans, j - i + 1);
            }

            return ans;
        }
    }

    class Counter : Dictionary<int, int>
    {
        public int Get(int k)
        {
            return base.TryGetValue(k, out int v) ? v : 0;
        }

        public void Increament(int k, int v)
        {
            if (TryGetValue(k, out int value))
            {
                base[k] = value + v;
            }
        }
    }
}
