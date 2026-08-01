public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int []nums1=new int[2*nums.Length];
        Array.Copy(nums,0,nums1,0,nums.Length);
        Array.Copy(nums,0,nums1,nums.Length,nums.Length);
        return nums1;
    }
}