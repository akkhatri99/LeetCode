public class Solution {
    public int MaxProductDifference(int[] nums) {
        nums = nums.OrderByDescending(x => x).ToArray();
        return ((nums[0] * nums[1]) - (nums[nums.Length - 1] * nums[nums.Length - 2]));  
    }
}