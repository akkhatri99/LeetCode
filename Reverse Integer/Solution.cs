public class Solution {
    public int Reverse(int x) {
        try {
            if(x < 0) {
            return (-1*Int32.Parse(new string(x.ToString().Where(x => x != '-').Reverse().ToArray())));
            }
            else {
                return (Int32.Parse(new string(x.ToString().Where(x => x != '-').Reverse().ToArray())));
            }
        }
        catch (Exception e) {
            return 0;
        }
    }
}