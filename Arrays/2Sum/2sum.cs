using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Arrays._2Sum
{
    class _2sum
    {
        public int[] twoSum(int[] nums, int target)
        {
            Dictionary<Int32, Int32> map = new Dictionary<Int32, Int32>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(target - nums[i]))
                    return new int[] { map[target - nums[i]], i };
                else map[nums[i]] = i;
            }
            return null;
        }
    }
}
