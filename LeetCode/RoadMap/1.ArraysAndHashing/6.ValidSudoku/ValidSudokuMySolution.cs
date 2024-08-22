public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        Dictionary<int,int> rows = new Dictionary<int,int>();
        Dictionary<int,int> columns = new Dictionary<int,int>();
        Dictionary<int,int> squares = new Dictionary<int,int>();
        for(int i = 0; i < 9; i++ )
        {
            for(int j = 0; j < 9; j++ )
            {
                //rows
                bool success = int.TryParse(board[i][j].ToString(),out int value);
                if(success)
                {
                    if(rows.ContainsKey(value))
                    {
                        return false;
                    }
                    else
                    {
                        rows[value] = 1;
                    }
                }
                //columns
                success = int.TryParse(board[j][i].ToString(),out int value2);
                if(success)
                {
                    if(columns.ContainsKey(value2))
                    {
                        return false;
                    }
                    else
                    {
                        columns[value2] = 1;
                    }
                }
            }
            columns.Clear();
            rows.Clear();
        }
        //squares
        for(int i = 0; i <= 6; i+=3 )
        {
            for(int j = 0; j <= 6; j+=3)
            {
                for(int k = i; k <= i + 2; k++)
                {
                    for(int l = j; l <= j + 2; l++)
                    {
                        bool success = int.TryParse(board[k][l].ToString(),out int value);
                        if(success)
                        {
                            if(squares.ContainsKey(value))
                            {
                                return false;
                            }
                            else
                            {
                                squares[value] =1;
                            }
                        }
                    }
                }
                squares.Clear();
            }
            
        }
        return true;
    }
}
