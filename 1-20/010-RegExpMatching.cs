public class Solution
{
  public bool IsMatch(string s, string p)
  {
    return Helper(s, 0, p, 0, new Dictionary<string, bool>());
  }

  public bool Helper(string s, int i, string p, int j, Dictionary<string, bool> dict)
  {
    if (j >= p.Length) return i >= s.Length;
    bool firstMatch = (i < s.Length && (p[j] == s[i] || p[j] == '.'));

    string key = i + ":" + j;
    if (!dict.ContainsKey(key))
    {
      if (j < p.Length - 1 && p[j + 1] == '*')
      {
        dict[key] = (firstMatch && Helper(s, i + 1, p, j, dict)) || Helper(s, i, p, j + 2, dict);
      }
      else
      {
        dict[key] = firstMatch && Helper(s, i + 1, p, j + 1, dict);
      }
    }
    return dict[key];
  }
}