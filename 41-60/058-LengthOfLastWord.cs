public class Solution
{
  public int LengthOfLastWord(string s)
  {
    int from = -1;
    for (int i = s.Length - 1; i >= 0; i--)
    {
      if (s[i] == ' ' && from > 0) return from - i;
      if (s[i] != ' ' && from < 0) from = i;
    }
    return from + 1;
  }

  /*
  public int LengthOfLastWord(string s)
  {
    int count = 0;
    for (int i = s.Length - 1; i >= 0; i--)
    {
      if (count > 0 && s[i] == ' ') return count;
      if (s[i] != ' ') count++;
    }
    return count;
  }
  */
}