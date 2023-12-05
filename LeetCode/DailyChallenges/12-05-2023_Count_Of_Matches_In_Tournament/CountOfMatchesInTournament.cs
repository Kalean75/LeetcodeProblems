public class Solution {
    public int NumberOfMatches(int n) 
    {
        int numMatches = 0;
        while( n >= 2 )
        {
            if(n % 2 == 0)
            {
                n = n/2;
                numMatches += n;
            }
            else
            {
                n = (n-1)/2;
                numMatches += n + 1;
            }
        }
        return numMatches;
    }
}