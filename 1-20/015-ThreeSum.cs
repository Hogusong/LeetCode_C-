public class Solution
{
  public IList<IList<int>> ThreeSum(int[] nums)
  {
    IList<IList<int>> ans = new List<IList<int>>();
    if (nums.Length < 3) return ans;
    Array.Sort(nums);
    HashSet<string> set = new HashSet<string>();

    for (int i = 0; i < nums.Length - 2; i++)
    {
      if (i > 0 && nums[i] == nums[i - 1]) continue;
      int l = i + 1;
      int r = nums.Length - 1;
      while (l < r)
      {
        if (l > i + 1 && nums[l - 1] == nums[l])
        {
          l++;
          continue;
        }
        if (r < nums.Length - 1 && nums[r + 1] == nums[r])
        {
          r--;
          continue;
        }
        if (nums[i] + nums[l] + nums[r] == 0)
        {
          ans.Add(new List<int>() { nums[i], nums[l], nums[r] });
          l++;
          r--;
        }
        else
        {
          if (nums[i] + nums[l] + nums[r] > 0) r--;
          else l++;
        }
      }
    }
    return ans;
  }

  /*
  public class Solution
  {
    public IList<IList<int>> ThreeSum(int[] nums)
    {
      IList<IList<int>> ans = new List<IList<int>>();
      if (nums.Length < 3) return ans;
      Array.Sort(nums);

      for (int i = 0; i < nums.Length - 2 && nums[i] <= 0; i++)
      {
        if (i > 0 && nums[i] == nums[i - 1]) continue;
        int l = i + 1;
        int r = nums.Length - 1;
        while (l < r)
        {
          if (l > i + 1 && nums[l - 1] == nums[l])
          {
            l++;
            continue;
          }
          if (r < nums.Length - 1 && nums[r + 1] == nums[r])
          {
            r--;
            continue;
          }
          if (nums[i] + nums[l] + nums[r] == 0)
          {
            ans.Add(new List<int>() { nums[i], nums[l++], nums[r--] });
          }
          else
          {
            if (nums[i] + nums[l] + nums[r] > 0) r--;
            else l++;
          }
        }
      }
      return ans;
    }
  }
  */
}