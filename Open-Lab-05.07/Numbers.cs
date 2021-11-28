using System;
using System.Linq;

namespace Open_Lab_05._07
{
    public class Numbers
    {
        public int[] RemoveSmallest(int[] nums)
        {
            int najmensieCislo = 100;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < najmensieCislo)
                {
                    najmensieCislo = nums[i];
                }
            }
            nums = nums.Where(val => val != najmensieCislo).ToArray();
            return nums;
        }
    }
}
