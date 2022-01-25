public class Solution
{
  public IList<IList<int>> CombinationSum2(int[] candidates, int target)
  {
    Array.Sort(candidates);
    HashSet<string> set = new HashSet<string>();
    IList<IList<int>> ans = new List<IList<int>>();
    BackTrack(candidates, 0, target, set, new List<int>(), ans);
    return ans;
  }

  public void BackTrack(int[] c, int s, int t, HashSet<string> set, IList<int> list, IList<IList<int>> ans)
  {
    if (t == 0)
    {
      string key = string.Join(",", list);
      if (!set.Contains(key))
      {
        set.Add(key);
        ans.Add(new List<int>(list));
      }
    }

    for (int i = s; i < c.Length; i++)
    {
      list.Add(c[i]);
      BackTrack(c, i + 1, t - c[i], set, list, ans);
      list.RemoveAt(list.Count - 1);
    }
  }
}