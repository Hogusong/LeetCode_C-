public class Solution
{
  public bool IsValidSudoku(char[][] board)
  {
    return IsValidRows(board) && IsValidColumns(board) && IsValidSquares(board);
  }

  public bool IsValidRows(char[][] board)
  {
    int size = 9;
    for (int r = 0; r < size; r++)
    {
      for (int c = 0; c < size; c++)
      {
        if (board[r][c] == '.') continue;
        for (int i = 0; i < size; i++)
        {
          if (i == c) continue;
          if (board[r][c] == board[r][i])
          {
            return false;
          }
        }
      }
    }
    return true;
  }

  public bool IsValidColumns(char[][] board)
  {
    int size = 9;
    for (int c = 0; c < size; c++)
    {
      for (int r = 0; r < size; r++)
      {
        if (board[r][c] == '.') continue;
        for (int i = 0; i < size; i++)
        {
          if (i == r) continue;
          if (board[r][c] == board[i][c])
          {
            return false;
          }
        }
      }
    }
    return true;
  }

  public bool IsValidSquares(char[][] board)
  {
    int size = 9;
    for (int r = 0; r < size; r++)
    {
      for (int c = 0; c < size; c++)
      {
        if (board[r][c] == '.') continue;
        int x = r / 3;
        int y = c / 3;
        for (int i = 3 * x; i < 3 * x + 3; i++)
        {
          for (int j = 3 * y; j < 3 * y + 3; j++)
          {
            if ((r == i) && (c == j)) continue;
            if (board[r][c] == board[i][j])
            {
              return false;
            }
          }
        }
      }
    }
    return true;
  }
}