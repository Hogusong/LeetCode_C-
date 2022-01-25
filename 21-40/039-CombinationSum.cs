public class Solution
{
  public IList<IList<int>> CombinationSum(int[] candidates, int target)
  {
    Array.Sort(candidates);
    IList<IList<int>> ans = new List<IList<int>>();
    FindCombination(candidates, 0, target, new HashSet<string>(), new List<int>(), ans);
    return ans;
  }

  public void FindCombination(int[] c, int i, int t, HashSet<string> set, IList<int> list, IList<IList<int>> ans)
  {
    if (t == 0)
    {
      string key = string.Join(",", list);
      if (!set.Contains(key))
      {
        ans.Add(list);
        set.Add(key);
      }
      return;
    }
    if (i >= c.Length || c[i] > t) return;

    IList<int> alist = new List<int>(list);
    alist.Add(c[i]);
    FindCombination(c, i, t - c[i], set, alist, ans);
    FindCombination(c, i + 1, t, set, list, ans);
  }
}