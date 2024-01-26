public class Solution {
    public int[] Decode(int[] encoded, int first) {
        int[] result = new int[encoded.Length+1];
        result[0] = first;
        for(int i = 0 ; i < encoded.Length; i++){
            result[i+1] = result[i] ^ encoded[i];
        }
        return result;
    }
}