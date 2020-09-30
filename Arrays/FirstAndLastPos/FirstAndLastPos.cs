using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Arrays.FirstAndLastPos
{
    class FirstAndLastPos
    {
        public int[] searchRange(int[] nums, int target)
        {
            int[] result = new int[2];
            result[0] = findFirst(nums, target);
            result[1] = findLast(nums, target);
            return result;
        }

        private int findFirst(int[] nums, int target)
        {
            int idx = -1;
            int start = 0;
            int end = nums.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (nums[mid] >= target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
                if (nums[mid] == target) idx = mid;
            }
            return idx;
        }

        private int findLast(int[] nums, int target)
        {
            int idx = -1;
            int start = 0;
            int end = nums.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (nums[mid] <= target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
                if (nums[mid] == target) idx = mid;
            }
            return idx;
        }


        // Alternate

        public int[] SearchRange(int[] nums, int target)
        {
            int[] targetRange = { -1, -1 };

            // find the index of the leftmost appearance of `target`.
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    targetRange[0] = i;
                    break;
                }
            }

            // if the last loop did not find any index, then there is no valid range
            // and we return [-1, -1].
            if (targetRange[0] == -1)
            {
                return targetRange;
            }

            // find the index of the rightmost appearance of `target` (by reverse
            // iteration). it is guaranteed to appear.
            for (int j = nums.Length - 1; j >= 0; j--)
            {
                if (nums[j] == target)
                {
                    targetRange[1] = j;
                    break;
                }
            }

            return targetRange;
        }

    }
}
