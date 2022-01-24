public class Solution
{
  public IList<string> LetterCombinations(string digits)
  {
    IList<string> output = new List<string>();
    if (digits.Length < 1) return output;
    output.Add("");
    Dictionary<string, string> dict = new Dictionary<string, string>() { { "2", "abc" }, { "3", "def" }, { "4", "ghi" }, { "5", "jkl" }, { "6", "mno" }, { "7", "pqrs" }, { "8", "tuv" }, { "9", "wxyz" } };
    foreach (char d in digits)
    {
      IList<string> temp = output;
      output = new List<string>();
      string str = dict[d.ToString()];
      foreach (char c in str)
      {
        foreach (string t in temp)
        {
          output.Add(t + c.ToString());
        }
      }
    }
    return output;
  }

  /*
  public IList<string> LetterCombinations(string digits)
  {
    IList<string> ans = new List<string>();
    if (digits.Length < 1) return ans;
    ans.Add("");
    string[] strs = new string[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
    foreach (char c in digits)
    {
      int d = (c - '0') - 2;
      IList<string> temp = new List<string>(ans);
      ans.Clear();
      foreach (char s in strs[d])
      {
        foreach (string word in temp)
        {
          ans.Add(word + s);
        }
      }
    }
    return ans;
  }
  */
}