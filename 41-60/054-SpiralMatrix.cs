public class Solution
{
  public IList<int> SpiralOrder(int[][] matrix)
  {
    IList<int> list = new List<int>();
    int m = matrix.Length, n = matrix[0].Length;
    int uEnd = 1, dEnd = m - 1, lEnd = 0, rEnd = n - 1;
    bool toRight = true, toLeft = false, toDown = false, toUp = false;
    int r = 0, c = 0;
    while (list.Count < m * n)
    {
      list.Add(matrix[r][c]);
      if (toRight)
      {
        if (c < rEnd) c++;
        else
        {
          rEnd--;
          r++;
          toRight = false;
          toDown = true;
        }
      }
      else if (toDown)
      {
        if (r < dEnd) r++;
        else
        {
          dEnd--;
          c--;
          toDown = false;
          toLeft = true;
        }
      }
      else if (toLeft)
      {
        if (c > lEnd) c--;
        else
        {
          lEnd++;
          r--;
          toLeft = false;
          toUp = true;
        }
      }
      else if (toUp)
      {
        if (r > uEnd) r--;
        else
        {
          uEnd++;
          c++;
          toUp = false;
          toRight = true;
        }
      }
    }
    return list;
  }
}