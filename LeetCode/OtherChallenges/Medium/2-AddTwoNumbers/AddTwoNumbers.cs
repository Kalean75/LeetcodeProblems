/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        if(l1 == null || l2 == null)
        {
            return new ListNode();
        }
        ListNode answer = new ListNode();
        String listNum1 = "";
        String listNum2 = "";
        BigInteger num1 = 0;
        BigInteger num2 = 0;
        BigInteger answerInt = 0;

        while(l1.next != null || l2.next != null)
        {
            if(l1.next != null)
            {
                listNum1 += l1.val;
                l1 = l1.next;
            }

             if(l2.next != null)
            {
                listNum2 += l2.val;
                l2 = l2.next;
            }
        }
        listNum1 += l1.val;
        listNum2 += l2.val;
        //reverse
        char[] charArray = listNum1.ToCharArray();
        Array.Reverse(charArray);
        listNum1 = new String(charArray);
        charArray = listNum2.ToCharArray();

        Array.Reverse(charArray);
        listNum2 = new String(charArray);

        BigInteger.TryParse(listNum1, out num1);
        BigInteger.TryParse(listNum2, out num2);
        answerInt = num1 + num2;

        String answerString = answerInt.ToString();
        char[] answerChar = answerString.ToCharArray();

        ListNode current = answer;
        for(int i = answerChar.Length - 1; i >= 0;i--)
        {
            current.next = new ListNode(answerChar[i] - '0');
            current = current.next;
        }
        

        return answer.next;
    }
}