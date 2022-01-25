public class Solution
{
  public int MaxSubArray(int[] nums)
  {
    int maxS = nums[0], sum = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
      sum = Math.Max(sum + nums[i], nums[i]);
      maxS = Math.Max(sum, maxS);
    }
    return maxS;
  }
}