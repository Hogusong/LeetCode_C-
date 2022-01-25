public class Solution
{
  public IList<IList<string>> SolveNQueens(int n)
  {
    IList<IList<string>> ans = new List<IList<string>>();
    for (int i = 0; i < n; i++)
    {
      IList<int[]> list = new List<int[]>();
      CheckPosition(0, i, n, list, ans);
    }
    return ans;
  }

  public void CheckPosition(int r, int c, int n, IList<int[]> list, IList<IList<string>> ans)
  {
    if (!isPossiblePosition(r, c, n, list)) return;
    list.Add(new int[] { r, c });
    if (list.Count == n)
    {
      IList<string> slist = new List<string>();
      foreach (int[] nums in list)
      {
        string str = "";
        for (int i = 0; i < n; i++) str += (i == nums[1] ? "Q" : ".");
        slist.Add(str);
      }
      ans.Add(slist);
      return;
    }

    for (int i = 0; i < n; i++)
    {
      CheckPosition(r + 1, i, n, new List<int[]>(list), ans);
    }
  }

  public bool isPossiblePosition(int r, int c, int n, IList<int[]> list)
  {
    foreach (int[] nums in list)
    {
      int x = nums[0], y = nums[1];
      if (r == x || c == y || r + c == x + y || r - c == x - y) return false;
    }
    return true;
  }
}