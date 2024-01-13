public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        if (arr.Length >= 3) {
            var sum = arr.Length%2 == 1 ? arr.Sum()*2 : arr.Sum();
            for(int i = 3; i< arr.Length; i++) {
                if(i % 2 == 1) {
                    sum += Enumerable.Range(0, arr.Length - i + 1)
                                .Select(u => arr.Skip(u).Take(i).Sum()).Sum();
                }
            }
            return sum;
        }
        return arr.Sum();
    }
}