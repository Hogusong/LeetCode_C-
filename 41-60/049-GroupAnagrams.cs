public class Solution
{
  public IList<IList<string>> GroupAnagrams(string[] strs)
  {
    Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
    foreach (string s in strs)
    {
      string[] str = new string[s.Length];
      for (int i = 0; i < s.Length; i++) str[i] = s[i].ToString();
      Array.Sort(str);
      string key = string.Join("", str);
      if (str == "") key = "....";
      if (!dict.ContainsKey(key)) dict[key] = new List<string>();
      dict[key].Add(s);
    }
    return new List<IList<string>>(dict.Values);
  }
}