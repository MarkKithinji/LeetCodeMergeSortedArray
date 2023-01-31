// See https://aka.ms/new-console-template for more information
using LeetCodeMergeSortedArray;

Console.WriteLine("Hello, World!");


//You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

//Merge nums1 and nums2 into a single array sorted in non-decreasing order.

//The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.


int[] nums1 = {1,3,6,5,7};
int m = 3;

int[] nums2= {4,5,8,6,7};
int n = 3;

Solution Testdata= new Solution();
Testdata.Merge(nums1, m, nums2, n);

//! Leetcode analysis
// Runtime: 140ms - beats 82%
// Memory: 42.5 MB - beats 58.7%

