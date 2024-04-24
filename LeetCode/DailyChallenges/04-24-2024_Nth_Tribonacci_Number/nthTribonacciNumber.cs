public class Solution {
    public int Tribonacci(int n) 
    {
        List<int> sequences = new List<int>();
        sequences.Add(0); //1
        sequences.Add(1); //2
        sequences.Add(1); //3
        int currNum = 0;
        if(n < 3)
        {
            return sequences[n];
        }
        for(int i = 3; i <= n; i++)
        {
            currNum = sequences[0] + sequences[1] + sequences[2];
            sequences[0] = sequences[1];
            sequences[1] = sequences[2];
            sequences[2] = currNum;
        }
        return currNum;
    }
}