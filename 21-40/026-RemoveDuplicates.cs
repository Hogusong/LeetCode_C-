public class Solution
{
  public int RemoveDuplicates(int[] nums)
  {
    if (nums.Length < 2) return nums.Length;
    int prev = nums[0], index = 1;
    for (int i = 1; i < nums.Length; i++)
    {
      if (nums[i] != nums[index - 1])
      {
        nums[index] = nums[i];
        index++;
      }
    }
    return index;
  }

  /*
  public int RemoveDuplicates(int[] nums)
  {
    if (nums.Length < 2) return nums.Length;
    int prev = nums[0], index = -1;
    for (int i = 1; i < nums.Length; i++)
    {
      if (nums[i] != prev)
      {
        prev = nums[i];
        if (index < 0) continue;
        nums[index++] = nums[i];
      }
      else
      {
        if (index < 0) index = i;
      }
    }
    return index < 0 ? nums.Length : index;
  }
  */
}