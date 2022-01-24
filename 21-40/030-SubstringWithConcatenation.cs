public class Solution
{
  public IList<int> FindSubstring(string s, string[] words)
  {
    IList<int> ans = new List<int>();
    if (s.Length < words.Length * words[0].Length) return ans;
    Dictionary<string, int> dict = new Dictionary<string, int>();
    foreach (string word in words)
    {
      if (!dict.ContainsKey(word)) dict[word] = 1;
      else dict[word]++;
    }
    int len = words[0].Length;
    int sLen = s.Length, wLen = words.Length;
    for (int i = 0; i <= sLen - (len * wLen); i++)
    {
      string word = s.Substring(i, len);
      if (!dict.ContainsKey(word)) continue;
      Dictionary<string, int> temp = new Dictionary<string, int>(dict);
      if (IsIncluded(temp, s.Substring(i, len * wLen), len)) ans.Add(i);
    }
    return ans;
  }

  public bool IsIncluded(Dictionary<string, int> dict, string str, int len)
  {
    int i = 0;
    while (i < str.Length)
    {
      string word = str.Substring(i, len);
      if (!dict.ContainsKey(word)) return false;
      dict[word]--;
      if (dict[word] == 0) dict.Remove(word);
      i += len;
    }
    Console.WriteLine();
    return dict.Count == 0;
  }
  /*
  public IList<int> FindSubstring(string s, string[] words)
  {
    int wLen = words[0].Length;
    int tLen = wLen * words.Length;
    IList<int> ans = new List<int>();
    if (tLen > s.Length) return ans;
    for (int i = 0; i <= s.Length - tLen; i++)
    {
      if (!words.Contains(s.Substring(i, wLen))) continue;
      if (isValid(s, words, i, wLen, tLen)) ans.Add(i);
    }
    return ans;
  }

  public bool isValid(string s, string[] words, int i, int wLen, int tLen)
  {
    Dictionary<string, int> dict = new Dictionary<string, int>();
    foreach (string w in words)
    {
      if (!dict.ContainsKey(w)) dict[w] = 1;
      else dict[w] += 1;
    }
    for (int j = 0; j < tLen; j += wLen)
    {
      string str = s.Substring(i + j, wLen);
      if (!dict.ContainsKey(str)) return false;
      if (dict[str] < 1) return false;
      dict[str] = dict[str] - 1;
    }
    return true;
  }
  */
}