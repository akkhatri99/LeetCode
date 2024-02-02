public class Solution {
    public int Divide(int dividend, int divisor) {
         if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
        bool isNegative = (dividend < 0) ^ (divisor < 0);
        long dividendAbs = Math.Abs((long)dividend);
        long divisorAbs = Math.Abs((long)divisor);
        int result = 0;
        while (dividendAbs >= divisorAbs) 
        {
            long temp = divisorAbs, multiple = 1;
            while (dividendAbs >= (temp << 1)) 
            {
                temp <<= 1;
                multiple <<= 1;
            }
            dividendAbs -= temp;
            result += (int)multiple;
        }
        return isNegative ? -result : result;
    }
}