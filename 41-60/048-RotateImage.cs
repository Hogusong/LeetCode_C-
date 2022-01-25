public class Solution
{
  public void Rotate(int[][] matrix)
  {
    int m = matrix.Length;
    for (int r = 0; r < m / 2; r++)
    {
      int[] temp = matrix[r];
      matrix[r] = matrix[m - r - 1];
      matrix[m - r - 1] = temp;
    }

    for (int r = 0; r < m; r++)
    {
      for (int c = r; c < m; c++)
      {
        int temp = matrix[r][c];
        matrix[r][c] = matrix[c][r];
        matrix[c][r] = temp;
      }
    }
  }
}