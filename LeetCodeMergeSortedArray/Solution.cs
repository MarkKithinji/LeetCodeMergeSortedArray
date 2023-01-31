using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMergeSortedArray
{
    internal class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] Unordered = new int[m + n];

            for(int i = 0; i < m; i++)
            {
                Unordered[i] = nums1[i];
            }
            for(int i = 0; i < n; i++)
            {
                Unordered[i + m] = nums2[i];
            }
            
            Array.Sort(Unordered);
            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = Unordered[i];
                Console.WriteLine(nums1[i]);
            }
            
        }
    }
}
