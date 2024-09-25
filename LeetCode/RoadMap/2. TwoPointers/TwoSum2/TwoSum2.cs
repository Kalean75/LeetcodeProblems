public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int lastIndex = numbers.Length - 1;
        int firstIndex = 0;
        int[] answer = new int[2];
        while(lastIndex >= firstIndex)
        {
            if(numbers[firstIndex] + numbers[lastIndex] > target)
            {
                lastIndex--;
            }
            if(numbers[firstIndex] + numbers[lastIndex] < target)
            {
                firstIndex++;
            }
            if(numbers[firstIndex] + numbers[lastIndex] == target)
            {
                break;
            }
        }
        answer[0] = firstIndex + 1;
        answer[1] = lastIndex + 1;

        return answer;
    
    }
}