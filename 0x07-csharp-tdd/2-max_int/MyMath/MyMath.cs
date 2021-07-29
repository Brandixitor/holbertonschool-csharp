using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>Represents a Operations class.</summary>
    public class Operations
    {
        /// <summary>Get the max integer in a list of integers. </summary>
        /// <param name="nums">List of integers.</param>
        /// <returns>Max integer in list.</returns>
        public static int Max(List<int> nums){
            int max = 0;
            try{
                max = nums[0];
            }
            catch{
                return 0;
            }
            foreach(var elem in nums)
                max = elem > max ? elem : max;
            return max;
        }
    }
}
