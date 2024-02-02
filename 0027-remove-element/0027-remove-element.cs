public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0;
        foreach (var num in nums) {
            if (num != val){
                nums[i] = num;
                i++;
            }
        }
        return i;
    }
}