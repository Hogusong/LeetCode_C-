public class Solution
{
  public string LongestCommonPrefix(string[] strs)
  {
    string prefix = strs[0];
    for (int j = 1; j < strs.Length; j++)
    {
      string common = "";
      for (int i = 0; i < prefix.Length && i < strs[j].Length; i++)
      {
        if (strs[j][i] == prefix[i]) common += strs[j][i];
        else break;
      }
      prefix = common;
    }
    return prefix;
  }
  /*
  public string LongestCommonPrefix(string[] strs)
  {
    if (strs.Length < 1) return "";
    string prefix = strs[0];
    foreach (string str in strs)
    {
      string common = "";
      for (int i = 0; i < prefix.Length && i < str.Length; i++)
      {
        if (str[i] == prefix[i]) common += str[i];
        else break;
      }
      if (common.Length < 1) return "";
      prefix = common;
    }
    return prefix;
  }
  */
}