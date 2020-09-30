using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Arrays.BinarySearchInRotatedArray
{
    class RotatedArray
    {
        int search(int[] nums, int target)
        {
            int lo = 0, hi = nums.Length;
            while (lo < hi)
            {
                int mid = (lo + hi) / 2;

                double num = (nums[mid] < nums[0]) == (target < nums[0])
                           ? nums[mid]
                           : target < nums[0] ? double.NegativeInfinity : double.PositiveInfinity;

                if (num < target)
                    lo = mid + 1;
                else if (num > target)
                    hi = mid;
                else
                    return mid;
            }
            return -1;
        }
    }
}
