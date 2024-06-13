minimumNumberOfMovesToSeatEveryonepublic class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) 
    {
        Array.Sort(seats);
        Array.Sort(students);
        int counter = 0;
        for(int i = 0; i < seats.Length; i++)
        {
            counter += Math.Abs(seats[i] - students[i]);
        }
        return counter;
    }
}