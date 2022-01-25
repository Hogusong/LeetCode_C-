public class Solution
{
  public bool IsMatch(string s, string p)
  {
    if (s == "")
    {
      if (p == "") return true;
      foreach (char c in p) if (c != '*') return false;
      return true;
    }

    int m = s.Length, n = p.Length;
    bool[,] dp = new bool[m + 1, n + 1];
    dp[0, 0] = true;
    for (int j = 0; j < n; j++)
    {
      if (p[j] == '*') dp[0, j + 1] = dp[0, j];
      else dp[0, j + 1] = false;
    }

    for (int r = 0; r < m; r++)
    {
      for (int c = 0; c < n; c++)
      {
        if (s[r] == p[c] || p[c] == '?') dp[r + 1, c + 1] = dp[r, c];
        else if (p[c] == '*') dp[r + 1, c + 1] = dp[r + 1, c] || dp[r, c + 1];
        else dp[r + 1, c + 1] = false;
      }
    }
    return dp[m, n];
  }
}