using System;

namespace BasicExercisesOne
{
    public class ExerciseMethods
    {
        // implement this method so it returns the sum of all the entries in the array nums
        public static int SumArray(int[] nums)
        {
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }
            return total;
        }

        public static bool EvenOdd(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
