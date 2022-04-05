using System.Collections.Generic;
using System.Linq;
using System;
namespace paiza_C.LeetCode
{
    public class TwoSum
    {
		internal static void main()
		{
			int[] nums = new int[4] { 2, 7, 11, 15 };
			int target = 9;
			Console.WriteLine(TwoSum_(nums,target));
		}

		public static int[] TwoSum_(int[] nums, int target)
		{
			// bool isMatch = false;
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[i] + nums[j] == target) return new int[2] { i, j };
				}
			}
			return new int[1] { 0 };
		}
	}
}
