using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DSA.LeetCode
{
    public class _27_Remove_Element
    {
        public int RemoveElement(int[] nums, int val)
        {
            //int[] numsremoved2= new int[0];
            int index = 0;
            foreach (int i in nums) { 
                if (i != val)
                    nums[index]=i; 
                index++; 
            }
            return index;

            //int[] numsremoved = nums.Where(i => i != val).ToArray();
            //nums=numsremoved;
            //return numsremoved.Length;

        }
    }
}
