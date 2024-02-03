public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if (target <= nums[0]) {return 0;}
        if (target > nums[nums.Length - 1]) {return nums.Length;}
        int i = 0;
        int j = nums.Length - 1;
        int result = 0;
        while (i <= j) {
            int mid = i + (j - i)/2;
            if (nums[mid] == target) {
                result = mid;
                break;
            }
            else if (nums[mid] < target) {
                Console.WriteLine("Code came here");
                i = mid + 1;
            }
            else {
                j = mid - 1;
            }
            if (j - i == 1 || j - i == 0) {
                if (nums [i] != target && nums[j] != target) {
                    if (nums [i] > target && nums [j] < target) {
                        result = j;
                    } 
                    else if (nums [j] < target) {
                        result = j + 1;
                    }
                    else if (nums[i] > target) {
                        result = i;
                    }
                    else {
                        result = i+1;
                    }
                    break;
                }
            }
        }
        return result;
    }
}