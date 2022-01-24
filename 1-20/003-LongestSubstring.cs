public class Solution
{
  public int LengthOfLongestSubstring(string s)
  {
    if (s.Length < 2) return s.Length;
    int maxL = 0, from = 0, index = -1;
    for (int i = 1; i < s.Length; i++)
    {
      index = s.IndexOf(s[i], from);
      if (index >= from && index < i)
      {
        maxL = Math.Max(maxL, i - from);
        from = index + 1;
      }
    }
    return index < 0 ? maxL : Math.Max(maxL, s.Length - from);
  }
}