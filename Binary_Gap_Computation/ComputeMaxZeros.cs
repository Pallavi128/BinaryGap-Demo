namespace BinaryGapComputation
{
    public class ComputeMaxZeros : IComputeMaxZeros
    {

        public int MaxZeros(int n)
        {
            if (n <= 0 || (n & (n - 1)) == 0)
                return 0;
    
            if (n == 0 || (n & (n - 1)) == 0)
                return 0;
 
            int setBit = 1, prev = 0, i;
            for (i = 1; i <= sizeof(int) * 8; i++)
            {
                prev++;

                if ((n & setBit) == setBit)
                {
                    setBit <<= 1;
                    break;
                }

                setBit = setBit << 1;
            }

            int max0 = int.MinValue, cur = prev;
            for (int j = i + 1; j <= sizeof(int) * 8; j++)
            {
                cur++;

                if ((n & setBit) == setBit)
                {
                    if (max0 < (cur - prev - 1))
                        max0 = cur - prev - 1;

                    prev = cur;
                }
                setBit = setBit << 1;
            }
            return max0;
        }
    }
}
