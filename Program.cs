using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace TwoSum
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target. 
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 8, 9, 10 };
            int target = 9;
            Solution.TwoSumMethod(nums, target);
        }
    }
    public class Solution
    {
        public static int[] TwoSumMethod(int[] nums, int target)
        {
            int[] hollowArray = new int[2];// Hollow array for return value
            bool found = false;// boolean variable to find value and break a loop
            for (int i = 0; i < nums.Length + 1; i++)//first loop for select index and sum to others
            {
                for (int j = i + 1; j < nums.Length; j++)//second loop to provide other indexes
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"[{i},{j}]");
                        hollowArray = new int[] { i, j };
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            return hollowArray;// a method return way should be written first
        }
    }
}