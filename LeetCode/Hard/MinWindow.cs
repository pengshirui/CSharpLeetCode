using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Hard
{
    public partial class Solution
    {
        public string MinWindow(string s, string t)
        {
            if (s?.Length < t?.Length)
            {
                return string.Empty;
            }

            var minWindowSize = int.MaxValue;
            var bestL = 0;
            var l = 0;
            var r = 0;
            // (char, (how many total, current number of char in the substring)
            var kv = new Dictionary<char, int>();
            foreach(var c in t)
            {
                if (kv.TryGetValue(c, out var count))
                {
                    kv[c] = count + 1;
                }
                else
                {
                    kv[c] = 1;
                }
            }

            var wkv = new Dictionary<char, int>();
            var completedCharCount = 0;
            var totalUniqueCharCount = kv.Count;
            while (r < s.Length)
            {
                
                var curChar = s[r];
                if (kv.TryGetValue(curChar, out var requiredCount))
                {
                    // hits
                    var newCount = wkv.TryGetValue(curChar, out var currentCount) ? currentCount : 0;
                    wkv[curChar] = newCount + 1;
                    if (requiredCount == wkv[curChar])
                    {
                        completedCharCount++;
                    }
                }

                while (l <= r && completedCharCount == totalUniqueCharCount)
                {
                    if (r - l + 1 < minWindowSize)
                    {
                        minWindowSize = r - l + 1;
                        bestL = l;
                    }
                    // keep moving the left pointer
                    var firstChar = s[l];
                    if (kv.TryGetValue(firstChar, out var requiredCount2))
                    {
                        var newCount2 = wkv[firstChar] - 1;
                        wkv[firstChar] = newCount2;
                        if (newCount2 < requiredCount2)
                        {
                            completedCharCount--;
                        }
                    }
                    l++;
                }
                r++;
            }

            return minWindowSize == int.MaxValue ? string.Empty : s.Substring(bestL, minWindowSize);
        }
    }
}
