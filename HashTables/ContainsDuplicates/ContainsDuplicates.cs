using System;
using System.Collections;
using System.Text;

namespace LeetCodeProblems.HashTables
{
    class ContainsDuplicates
    {
        public bool ContainsDuplicate(int[] nums)
        {

            Hashtable table = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (table.ContainsKey(nums[i]))
                {
                    return true;
                }
                else
                {
                    table.Add(nums[i], i);
                }
            }
            return false; 



        }
    }
}
