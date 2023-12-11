//Given an integer array sorted in non-decreasing order, there is exactly one integer in the array that occurs more than 25% of the time, return that integer.
public class Solution {
    public int FindSpecialInteger(int[] arr) 
    {
        int numCount = 0;
        int currNum = 0;
        int arrfourth = arr.Length / 4;
        Console.WriteLine(arrfourth);
        for(int i = 0; i < arr.Length;i++)
        {
            if(arr[i] != currNum)
            {
                numCount = 0;
                currNum = arr[i];
            }
            numCount += 1;
            if(numCount > arrfourth)
            {
                break;
            }
        }
        return currNum;
    }
}