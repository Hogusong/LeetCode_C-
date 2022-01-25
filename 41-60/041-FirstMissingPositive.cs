public class Solution
{
  public int FirstMissingPositive(int[] nums)
  {
    Array.Sort(nums);
    int index = FindOne(nums, 0, nums.Length - 1);
    if (index < 0) return 1;
    int expect = 2;
    for (int i = index + 1; i < nums.Length; i++)
    {
      if (nums[i] < expect) continue;
      if (nums[i] == expect) expect++;
      else return expect;
    }
    return expect;
  }

  public int FindOne(int[] nums, int from, int to)
  {
    if (from >= to) return nums[from] == 1 ? from : -1;
    int mid = (from + to) / 2;
    if (nums[mid] == 1) return mid;
    if (nums[mid] < 1) return FindOne(nums, mid + 1, to);
    else return FindOne(nums, from, mid);
  }
}