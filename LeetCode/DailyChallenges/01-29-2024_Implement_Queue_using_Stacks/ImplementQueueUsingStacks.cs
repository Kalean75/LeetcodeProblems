public class MyQueue 
{
    Stack<int> stack1 = new Stack<int>();
    Stack<int> stack2 = new Stack<int>();
    public MyQueue() 
    {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }
    
    public void Push(int x) 
    {
        stack1.Push(x);
        stack2.Clear();
        foreach (int element in stack1.ToArray())
        {
            stack2.Push(element);
        }
    }
    
    public int Pop() 
    {
        int num = stack2.Pop();
        stack1.Clear();
        foreach (int element in stack2.ToArray())
        {
            stack1.Push(element);
        }
        return num;
    }
    
    public int Peek() 
    {
        return stack2.Peek();
    }
    
    public bool Empty() 
    {
        if(stack2.Count() == 0 || stack1.Count() == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}