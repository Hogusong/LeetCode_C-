public class Solution
{
  public IList<IList<int>> Permute(int[] nums)
  {
    IList<IList<int>> ans = new List<IList<int>>();
    Helper(nums, new List<int>(), ans);
    return ans;
  }

  public void Helper(int[] nums, IList<int> list, IList<IList<int>> ans)
  {
    if (list.Count == nums.Length)
    {
      ans.Add(list);
      return;
    }
    foreach (int x in nums)
    {
      if (!list.Contains(x))
      {
        IList<int> alist = new List<int>(list);
        alist.Add(x);
        Helper(nums, alist, ans);
      }
    }
  }

  /*
  public IList<IList<int>> Permute(int[] nums)
  {
    IList<IList<int>> ans = new List<IList<int>>();
    if (nums.Length == 1)
    {
      ans.Add(new List<int>(nums));
      return ans;
    }
    IList<IList<int>> container = new List<IList<int>>();
    container.Add(new List<int>());
    while (container.Count > 0)
    {
      IList<IList<int>> temp = new List<IList<int>>(container);
      container = new List<IList<int>>();
      foreach (IList<int> list in temp)
      {
        foreach (int n in nums)
        {
          if (!list.Contains(n))
          {
            IList<int> aList = new List<int>(list);
            aList.Add(n);
            if (aList.Count == nums.Length) ans.Add(aList);
            else container.Add(aList);
          }
        }
      }
    }
    return ans;
  }
  */
}