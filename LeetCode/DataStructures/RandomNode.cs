﻿namespace LeetCode.DataStructures
{
    public class RandomNode
    {
        public int val;
        public RandomNode next;
        public RandomNode random;

        public RandomNode(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}
