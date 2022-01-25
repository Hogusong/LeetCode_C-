public class Solution
{
  public int Jump(int[] nums)
  {
    if (nums.Length < 2) return 0;
    int[] ans = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++) ans[i] = 0;
    for (int i = 0; i < nums.Length; i++)
    {
      for (int j = 1; j <= nums[i]; j++)
      {
        if (ans[i + j] == 0) ans[i + j] = ans[i] + 1;
        else ans[i + j] = Math.Min(ans[i + j], ans[i] + 1);
        if (ans[nums.Length - 1] > 0) return ans[nums.Length - 1];
      }
    }
    return 0;
  }

  /*
    public int Jump(int[] nums) {
        int len = nums.Length;
        if (len == 1) return 0;
        int[] ans = new int[len];
        for (int i = 1; i < len; i++) ans[i] = (i <= nums[0] ? 1 : 0);
        for (int i = 1; i < len; i++) {
            for (int j = i + 1; j <= i + nums[i] && j < len; j++) {
                if (ans[j] == 0) ans[j] = ans[i] + 1;
                else ans[j] = Math.Min(ans[i] + 1, ans[j]);
            }
            if (ans[len - 1] > 0) return ans[len - 1];
        }
        return ans[len - 1];
    }  
  */
}