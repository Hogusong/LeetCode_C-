public class Solution
{
  public int Search(int[] nums, int target)
  {
    int len = nums.Length;
    if (len == 1) return nums[0] == target ? 0 : -1;
    if (nums[0] < nums[len - 1]) return findTarget(nums, target, 0, len - 1);
    int pick = findPick(nums, 0, nums.Length - 1);
    if (target < nums[0]) return findTarget(nums, target, pick + 1, len - 1);
    return findTarget(nums, target, 0, pick);
  }

  public int findPick(int[] N, int from, int to)
  {
    if (from >= to) return from;
    int mid = (from + to) / 2;
    if ((mid == 0 || N[mid - 1] < N[mid]) && N[mid] > N[mid + 1]) return mid;
    if (N[mid] > N[0]) return findPick(N, mid + 1, to);
    return findPick(N, from, mid);
  }

  public int findTarget(int[] N, int T, int from, int to)
  {
    if (from >= to) return N[from] == T ? from : -1;
    int mid = (from + to) / 2;
    if (N[mid] == T) return mid;
    if (N[mid] < T) return findTarget(N, T, mid + 1, to);
    return findTarget(N, T, from, mid);
  }
}