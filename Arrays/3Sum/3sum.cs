using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Arrays._3Sum
{
    class _3sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();

            if (nums.Length < 3)
            {
                return result;
            }

            Array.Sort(nums);

            for (int first = 0; first < nums.Length - 2; first++)
            {
                int second = first + 1;
                int third = nums.Length - 1;

                if (first != 0 && nums[first] == nums[first - 1])
                {
                    continue;
                }

                while (second < third)
                {
                    if (second > first + 1 && nums[second] == nums[second - 1])
                    {
                        second++;
                        continue;
                    }

                    int sum = nums[first] + nums[second] + nums[third];

                    if (sum == 0)
                    {
                        var triple = new List<int>();
                        triple.Add(nums[first]);
                        triple.Add(nums[second]);
                        triple.Add(nums[third]);
                        result.Add(triple);
                        second++;
                        third--;
                    }
                    else if (sum > 0)
                    {
                        third--;
                    }
                    else
                    {
                        second++;
                    }
                }
            }

            return result;
        }
    }
}
