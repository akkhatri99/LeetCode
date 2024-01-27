public class Solution {
    public int MaxArea(int[] height) {
        int l = 0;
        int r = height.Length - 1;
        int max = 0;
        while (l < r) {
            int lowerHeight = height[l] < height[r] ? height[l] : height[r];
            int area = lowerHeight * (r-l);
            max = max > area ? max : area;
            if (height[l] < height[r]) {
                l++;
            }
            else {
                r--;
            }
        }
        return max;
    }
}