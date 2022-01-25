public class Solution
{
  public string Multiply(string num1, string num2)
  {
    if (num1 == "0" || num2 == "0") return "0";
    int len1 = num1.Length;
    int len2 = num2.Length;
    int m = len2 + 3;
    int n = len1 + len2;
    int[,] matrix = new int[m, n];
    for (int i = 0; i < len1; i++)
    {
      matrix[0, i] = num1[len1 - i - 1] - '0';
    }
    for (int i = 0; i < len2; i++)
    {
      matrix[1, i] = num2[len2 - i - 1] - '0';
    }
    for (int i = 2; i < m; i++)
    {
      for (int j = 0; j < n; j++) matrix[i, j] = 0;
    }
    for (int i = 0; i < len2; i++)
    {
      for (int j = 0; j < len1; j++)
      {
        int c = i + j;
        int prod = matrix[1, i] * matrix[0, j] + matrix[i + 2, c];
        matrix[i + 2, c] = prod % 10;
        matrix[i + 2, c + 1] = matrix[i + 2, c + 1] + (prod / 10);
      }
    }
    int up = 0;
    for (int c = 0; c < n; c++)
    {
      int sum = up;
      for (int r = 2; r < m - 1; r++)
      {
        sum += matrix[r, c];
      }
      up = sum / 10;
      matrix[m - 1, c] = sum % 10;
    }
    // printMatrix(matrix, m, n);

    string ans = matrix[m - 1, n - 1] == 0 ? "" : "" + matrix[m - 1, n - 1];
    for (int i = n - 2; i >= 0; i--)
    {
      ans += matrix[m - 1, i];
    }
    return ans;
  }

  public void printMatrix(int[,] matrix, int m, int n)
  {
    for (int r = 0; r < m; r++)
    {
      for (int c = 0; c < n; c++)
      {
        Console.Write(matrix[r, c] + ",");
      }
      Console.WriteLine();
    }
  }
}