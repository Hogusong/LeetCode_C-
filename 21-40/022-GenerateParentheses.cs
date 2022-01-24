public class Solution
{
  public IList<string> GenerateParenthesis(int n)
  {
    IList<string> ans = new List<string>();
    Generate(n - 1, n, "(", ans);
    return ans;
  }

  public void Generate(int o, int c, string str, IList<string> ans)
  {
    if (o == 0 && c == 0)
    {
      ans.Add(str);
      return;
    }
    if (o == 0) Generate(0, c - 1, str + ")", ans);
    else
    {
      if (o < c) Generate(o, c - 1, str + ")", ans);
      Generate(o - 1, c, str + "(", ans);
    }
  }
}