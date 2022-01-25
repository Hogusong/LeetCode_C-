public class Solution
{
  public int[] SearchRange(int[] nums, int target)
  {
    if (nums.Length < 1) return new int[] { -1, -1 };
    int index = FindTarget(nums, 0, nums.Length - 1, target);
    if (index < 0) return new int[] { -1, -1 };
    int left = index - 1;
    int right = index + 1;
    while (left >= 0 && nums[left] == target) left--;
    while (right < nums.Length && nums[right] == target) right++;
    return new int[] { left + 1, right - 1 };
  }

  public int FindTarget(int[] nums, int from, int to, int T)
  {
    if (from >= to) return nums[from] == T ? from : -1;
    int mid = (from + to) / 2;
    if (nums[mid] == T) return mid;
    if (nums[mid] < T) return FindTarget(nums, mid + 1, to, T);
    return FindTarget(nums, from, mid, T);
  }
}