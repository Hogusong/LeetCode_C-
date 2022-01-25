public class Solution
{
  public int TotalNQueens(int n)
  {
    int count = 0;
    for (int i = 0; i < n; i++)
    {
      count += CheckPosition(0, i, n, new List<int[]>());
    }
    return count;
  }

  public int CheckPosition(int r, int c, int n, List<int[]> list)
  {
    if (!isPossiblePosition(r, c, n, list)) return 0;
    list.Add(new int[] { r, c });
    if (list.Count == n) return 1;
    int count = 0;
    for (int i = 0; i < n; i++)
    {
      count += CheckPosition(r + 1, i, n, new List<int[]>(list));
    }
    return count;
  }

  public bool isPossiblePosition(int r, int c, int n, List<int[]> list)
  {
    foreach (int[] nums in list)
    {
      int x = nums[0], y = nums[1];
      if (x == r || c == y || x + y == r + c || x - y == r - c) return false;
    }
    return true;
  }
}