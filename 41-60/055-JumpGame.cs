public class Solution
{
  public bool CanJump(int[] nums)
  {
    int len = nums.Length;
    if (len == 1) return true;
    int maxP = nums[0];
    for (int i = 0; i <= maxP; i++)
    {
      maxP = Math.Max(maxP, i + nums[i]);
      if (maxP >= len - 1) return true;
    }
    return false;
  }
}