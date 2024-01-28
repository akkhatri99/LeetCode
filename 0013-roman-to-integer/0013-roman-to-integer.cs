public class Solution {
    public int RomanToInt(string s) {
        Dictionary<string, int> roman = new Dictionary<string, int>{
            { "M", 1000 },
            { "CM", 900 },
            { "D", 500 },
            { "CD", 400 },
            { "C", 100 },
            { "XC", 90 },
            { "L", 50 },
            { "XL", 40 },
            { "X", 10 },
            { "IX", 9 },
            { "V", 5 },
            { "IV", 4 },
            { "I", 1 }
        };
        int result = 0;
        for (int i = 0 ; i < s.Length; i++) {
            if (i == s.Length - 1) {
                result += roman[s[i].ToString()];
            }
            else {
                if (roman.Keys.Contains(s[i].ToString()+s[i+1].ToString())){
                result+=(roman.Where(x => x.Key == (s[i].ToString()+s[i+1].ToString())).First().Value);
                i++;
            }
            else {
                result+=(roman.Where(x => x.Key == s[i].ToString()).First().Value);
            }
            }
        }

        return result;
    }
}