public class Solution
{
  public int StrStr(string haystack, string needle)
  {
    if (needle == "") return 0;

    int index = haystack.IndexOf(needle[0]);
    while (index >= 0)
    {
      if (haystack.Length - index < needle.Length) return -1;
      if (haystack.Substring(index, needle.Length) == needle) return index;
      index = haystack.IndexOf(needle[0], index + 1);
    }
    return index;
  }
}