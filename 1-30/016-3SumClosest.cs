public class Solution
{
  public int ThreeSumClosest(int[] nums, int target)
  {
    Array.Sort(nums);
    int minGap = int.MaxValue;
    int cloest = 0;
    for (int i = 0; i < nums.Length - 2; i++)
    {
      if (i > 0 && nums[i - 1] == nums[i]) continue;
      int l = i + 1;
      int r = nums.Length - 1;
      while (l < r)
      {
        int sum = nums[i] + nums[l] + nums[r];
        if (sum == target) return target;
        int gap = Math.Abs(target - sum);
        if (gap < minGap)
        {
          minGap = gap;
          cloest = sum;
        }
        if (sum > target) r--;
        else l++;
      }
    }
    return cloest;
  }

  /*
  public class Solution
  {
    public int ThreeSumClosest(int[] nums, int target)
    {
      HashSet<int> set = new HashSet<int>();
      Array.Sort(nums);
      for (int i = 0; i < nums.Length - 2; i++)
      {
        if (i > 0 && nums[i - 1] == nums[i]) continue;
        for (int j = i + 1; j < nums.Length - 1; j++)
        {
          if (j > i + 1 && nums[j - 1] == nums[j]) continue;
          for (int k = j + 1; k < nums.Length; k++)
          {
            if (nums[i] + nums[j] + nums[k] == target) return target;
            set.Add(nums[i] + nums[j] + nums[k]);
          }
        }
      }
      int[] arr = set.ToArray();
      int n = 0;
      while (true)
      {
        if (set.Contains(target + n)) return target + n;
        if (set.Contains(target - n)) return target - n;
        n++;
      }
      return 0;
    }
  }
  */
}