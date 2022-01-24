public class Solution
{
  public int RomanToInt(string s)
  {
    var dict = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
    int ans = 0;
    for (int i = 0; i < s.Length; i++)
    {
      if (i < s.Length - 1 && dict[s[i]] < dict[s[i + 1]])
      {
        ans -= dict[s[i]];
      }
      else
      {
        ans += dict[s[i]];
      }
    }
    return ans;
  }
}