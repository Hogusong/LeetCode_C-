public class Solution
{
  public int RemoveElement(int[] nums, int val)
  {
    if (nums.Length < 1) return 0;
    int key = -1;
    for (int i = 0; i < nums.Length; i++)
    {
      if (nums[i] == val)
      {
        if (key < 0) key = i;
      }
      else if (key >= 0)
      {
        nums[key] = nums[i];
        key++;
      }
    }
    return key < 0 ? nums.Length : key;
  }
  /*
  public int RemoveElement(int[] nums, int val)
  {
    if (nums.Length < 1) return 0;
    int index = -1;
    for (int i = 0; i < nums.Length; i++)
    {
      if (nums[i] != val && index >= 0) nums[index++] = nums[i];
      else if (nums[i] == val && index < 0) index = i;
    }
    return index < 0 ? nums.Length : index;
  }
  */
}