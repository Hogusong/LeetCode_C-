public class Solution
{
  public string LongestPalindrome(string s)
  {
    if (s.Length < 2) return s;
    string ans = "";
    for (int i = 0; i < s.Length - 1; i++)
    {
      string sP = GetPalindrome(s, i, i);
      string dP = GetPalindrome(s, i, i + 1);
      if (ans.Length < sP.Length) ans = sP;
      if (ans.Length < dP.Length) ans = dP;
    }
    return ans;
  }

  public string GetPalindrome(string s, int l, int r)
  {
    if (s[l] != s[r]) return "";
    while (l >= 0 && r < s.Length && s[l] == s[r])
    {
      l--;
      r++;
    }
    return s.Substring(l + 1, r - l - 1);
  }
  /*
  public string LongestPalindrome(string s) {
      if (s.Length < 2) return s;
      int start = 0, len = 0;
      for (int i = 0; i < s.Length - 1; i++) {
          int[] sp = GetPalindrome(s, i, i);
          if (len < sp[1] - sp[0]) {
              len = sp[1] - sp[0];
              start = sp[0];
          }
          int[] dp = GetPalindrome(s, i, i + 1);
          if (len < dp[1] - dp[0]) {
              len = dp[1] - dp[0];
              start = dp[0];
          }
      }
      return s.Substring(start, len);
  }

  public int[] GetPalindrome(string s, int l, int r) {
      if (s[l] != s[r]) return new int[]{0,0};
      while (l >= 0 && r < s.Length && s[l] == s[r]) {
          l--;
          r++;
      }
      return new int[]{l+1, r};
  }
  */
}