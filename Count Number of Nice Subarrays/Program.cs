using System;

namespace Count_Number_of_Nice_Subarrays
{
  class Program
  {
    static void Main(string[] args)
    {
      var nums = new int[] { 6, 1, 3, 2, 8, 3, 1, 9, 6 };
      int k = 3;
      Solution s = new Solution();
      var answer = s.NumberOfSubarrays(nums, k);
      Console.WriteLine(answer);
    }
  }

  public class Solution
  {
    public int NumberOfSubarrays(int[] nums, int k)
    {
      int l = 0; int r = 0; int res = 0; int count = 0;
      while (r < nums.Length)
      {
        if (nums[r] % 2 == 1)
        {
          k--;
          count = 0;
        }

        while (k == 0)
        {
          if (nums[l] % 2 == 1)
          {
            k++;
          }
          l++;
          count++;
        }

        r++;
        res += count;
      }

      return res;
    }
  }
}
