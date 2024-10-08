 public List<List<int>> ThreeSum(int[] nums) 
    {
        List<Tuple<int,int,int>> tupleList = new List<Tuple<int,int,int>>();
        List<List<int>> answer = new List<List<int>>();
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 2; i++)
        {
            for(int j = i + 1; j < nums.Length - 1; j++)
            {
                for(int k = j + 1; k < nums.Length; k++)
                {
                    if(nums[i] + nums[j] + nums[k] == 0)
                    {
                        Tuple<int, int, int>  triplets = new Tuple<int,int,int>(nums[i],nums[j],nums[k]);
                        if(!tupleList.Contains(triplets))
                        {
                            tupleList.Add(triplets);
                        }
                    }
                }
            }
        }
        for(int i = 0; i < tupleList.Count;i++)
        {
            List<int> newList = new List<int>{tupleList[i].Item1,tupleList[i].Item2,tupleList[i].Item3};
            answer.Add(newList);
        }
        return answer;
    }