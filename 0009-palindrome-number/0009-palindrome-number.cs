public class Solution {
    public bool IsPalindrome(int x) {
        if (new string(x.ToString().Reverse().ToArray()) == x.ToString()) {
            return true;
        }
        else {
            return false;
        }
    }
}