public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string sample = strs.OrderBy(x => x.Length).First();
        for (int i = 0 ; i < sample.Length; i++) {
            if(strs.Select(x => x[i]).Distinct().Count() > 1) return sample[..i];
        }
        return sample;
    }
}