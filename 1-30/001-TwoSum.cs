public class Solution
{
  public int[] TwoSum(int[] nums, int target)
  {
    Dictionary<int, int> dict = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
      int k = target - nums[i];
      if (dict.ContainsKey(k)) return new int[] { dict[k], i };
      dict[nums[i]] = i;
    }
    return new int[] { };
  }
}