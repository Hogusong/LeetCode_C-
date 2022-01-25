public class Solution
{
  public int[][] GenerateMatrix(int n)
  {
    int[][] matrix = new int[n][];
    for (int i = 0; i < n; i++) matrix[i] = new int[n];
    bool toRight = true, toDown = false, toLeft = false, toUp = false;
    int uEnd = 1, rEnd = n - 1, dEnd = n - 1, lEnd = 0, r = 0, c = 0, x = 1;
    while (x <= n * n)
    {
      matrix[r][c] = x++;
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
    return matrix;
  }
}