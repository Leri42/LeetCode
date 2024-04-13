using System;
using System.Collections.Generic;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

       
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (!map.ContainsKey(diff))
                {
                    map[nums[i]] = i;
                }
                else
                {
                    result[0] = i;
                    result[1] = map[diff];
                    break;
                }
            }

            return result;
        }
    }
}
