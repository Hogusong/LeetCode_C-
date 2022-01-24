public class Solution
{
  public IList<IList<int>> FourSum(int[] nums, int target)
  {
    IList<IList<int>> ans = new List<IList<int>>();
    if (nums.Length < 4) return ans;
    Array.Sort(nums);
    HashSet<string> set = new HashSet<string>();
    for (int i = 0; i < nums.Length - 3; i++)
    {
      if (i > 0 && nums[i - 1] == nums[i]) continue;
      if (nums[i] > target && nums[i + 1] >= 0) break;
      for (int j = i + 1; j < nums.Length - 2; j++)
      {
        if (j > i + 1 && nums[j - 1] == nums[j]) continue;
        if (nums[i] + nums[j] > target && nums[j + 1] >= 0) break;
        int l = j + 1;
        int r = nums.Length - 1;
        while (l < r)
        {
          if (nums[i] + nums[j] + nums[l] > target && nums[l + 1] >= 0) break;
          if (l > j + 1 && nums[l - 1] == nums[l])
          {
            l++;
          }
          else if (r < nums.Length - 1 && nums[r + 1] == nums[r])
          {
            r--;
          }
          else if (nums[i] + nums[j] + nums[l] + nums[r] == target)
          {
            string key = nums[i].ToString() + ";" + nums[j].ToString() + ";" + nums[l].ToString() + ";" + nums[r].ToString();
            if (!set.Contains(key)) ans.Add(new List<int>() { nums[i], nums[j], nums[l], nums[r] });
            set.Add(key);
            l++;
            r--;
          }
          else
          {
            if (nums[i] + nums[j] + nums[l] + nums[r] > target) r--;
            else l++;
          }
        }
      }
    }
    return ans;
  }

  /*
  public IList<IList<int>> FourSum(int[] nums, int target)
  {
    IList<IList<int>> ans = new List<IList<int>>();
    if (nums.Length < 4) return ans;
    Array.Sort(nums);
    for (int i = 0; i < nums.Length - 3; i++)
    {
      if (i > 0 && nums[i - 1] == nums[i]) continue;
      int newT = target - nums[i];
      for (int j = i + 1; j < nums.Length - 2; j++)
      {
        if (j > i + 1 && nums[j - 1] == nums[j]) continue;
        int l = j + 1, r = nums.Length - 1;
        while (l < r)
        {
          if (l > j + 1 && nums[l - 1] == nums[l]) l++;
          else if (r < nums.Length - 1 && nums[r] == nums[r + 1]) r--;
          else if (nums[j] + nums[l] + nums[r] == newT)
          {
            ans.Add(new List<int>() { nums[i], nums[j], nums[l++], nums[r--] });
          }
          else
          {
            if (nums[j] + nums[l] + nums[r] > newT) r--;
            else l++;
          }
        }
      }
    }
    return ans;
  }
  */
}