public class Solution
{
  public IList<IList<int>> PermuteUnique(int[] nums)
  {
    IList<IList<int>> ans = new List<IList<int>>();
    if (nums.Length < 2)
    {
      IList<int> list = new List<int>(nums);
      ans.Add(list);
      return ans;
    }

    Helper(ans, nums, new List<int>(), new HashSet<string>());
    return ans;
  }

  public void Helper(IList<IList<int>> ans, int[] nums, IList<int> list, HashSet<string> set)
  {
    if (list.Count == nums.Length)
    {
      for (int i = 0; i < list.Count; i++)
      {
        list[i] = nums[list[i]];
      }
      string key = string.Join(",", list);
      if (!set.Contains(key))
      {
        set.Add(key);
        ans.Add(list);
      }
      return;
    }

    for (int i = 0; i < nums.Length; i++)
    {
      if (!list.Contains(i))
      {
        IList<int> aList = new List<int>(list);
        aList.Add(i);
        Helper(ans, nums, aList, set);
      }
    }
  }

  /*
  public IList<IList<int>> PermuteUnique(int[] nums)
  {
    IList<IList<int>> ans = new List<IList<int>>();
    if (nums.Length < 2)
    {
      IList<int> list = new List<int>(nums);
      ans.Add(list);
      return ans;
    }

    HashSet<string> set = new HashSet<string>();
    IList<IList<int>> container = new List<IList<int>>();
    container.Add(new List<int>());
    while (container.Count > 0)
    {
      IList<IList<int>> temp = new List<IList<int>>(container);
      container = new List<IList<int>>();
      foreach (IList<int> L in temp)
      {
        for (int i = 0; i < nums.Length; i++)
        {
          if (!L.Contains(i))
          {
            IList<int> aL = new List<int>(L);
            aL.Add(i);
            if (aL.Count == nums.Length)
            {
              for (int j = 0; j < nums.Length; j++)
              {
                aL[j] = nums[aL[j]];
              }
              string key = string.Join(",", aL);
              if (!set.Contains(key))
              {
                set.Add(key);
                ans.Add(aL);
              }
            }
            else container.Add(aL);
          }
        }
      }
    }
    return ans;
  }
  */
}