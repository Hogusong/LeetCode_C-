public class Solution
{
  public int LongestValidParentheses(string s)
  {
    if (s.Length < 1) return 0;
    int maxL = 0;
    int open = 0;
    int start = 0;
    for (int i = 0; i < s.Length; i++)
    {
      if (s[i] == '(') open++;
      else if (open == 0) start = i + 1;
      else
      {
        open--;
        if (open == 0) maxL = Math.Max(maxL, i - start + 1);
      }
    }
    int close = 0;
    start = s.Length - 1;
    for (int i = s.Length - 1; i > 0; i--)
    {
      if (s[i] == ')') close++;
      else if (close == 0) start = i - 1;
      else
      {
        close--;
        if (close == 0) maxL = Math.Max(maxL, start - i + 1);
      }
    }
    return maxL;
  }
}