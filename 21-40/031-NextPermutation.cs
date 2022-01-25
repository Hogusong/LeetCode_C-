public class Solution
{
  public int[] NextPermutation(int[] nums)
  {
    if (nums.Length < 2) return nums;

    int i = nums.Length - 2;
    while (i >= 0 && nums[i] >= nums[i + 1]) i--;

    if (i >= 0)
    {
      int j = nums.Length - 1;
      while (j > i && nums[i] >= nums[j]) j--;
      int temp = nums[i];
      nums[i] = nums[j];
      nums[j] = temp;
    }

    i++;
    int k = nums.Length - 1;
    while (i < k)
    {
      int temp = nums[i];
      nums[i] = nums[k];
      nums[k] = temp;
      i++;
      k--;
    }
    return nums;
  }
}