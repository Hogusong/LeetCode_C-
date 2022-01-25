public class Solution
{
  public int SearchInsert(int[] nums, int target)
  {
    int len = nums.Length;
    if (len == 1) return nums[0] < target ? 1 : 0;
    if (nums[0] >= target) return 0;
    if (nums[len - 1] < target) return len;
    return findSpot(nums, target, 0, len - 1);
  }

  public int findSpot(int[] N, int T, int from, int to)
  {
    if (from >= to) return from;
    int mid = (from + to) / 2;
    if (N[mid] == T) return mid;
    if (N[mid] < T) return findSpot(N, T, mid + 1, to);
    return findSpot(N, T, from, mid);
  }
}