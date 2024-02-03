public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int i = 0;
        int j = nums.Length - 1;
        int first = -1;
        int last = -1;
        while (i <= j) {
            int mid = i + (j - i)/2;
            if (nums[mid] == target) {
                first = mid;
                j = mid-1;
            }
            else if (nums[mid] < target) {
                i = mid + 1;
            }
            else {
                j = mid - 1;
            }
        }

        i = 0;
        j = nums.Length - 1;
        while (i <= j) {
            int mid = i + (j - i) / 2;

            if (nums[mid] == target) {
                last = mid; 
                i = mid + 1; 
            } else if (nums[mid] < target) {
                i = mid + 1;
            } else {
                j = mid - 1;
            }
        }
        return [first, last];
    }
}