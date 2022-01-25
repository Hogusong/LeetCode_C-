public class Solution
{
  public int[][] Insert(int[][] intervals, int[] newInterval)
  {
    if (intervals.Length == 0) return new int[][] { newInterval };
    List<int[]> ans = new List<int[]>();
    bool inserted = false;
    int[] x = newInterval;
    foreach (int[] y in intervals)
    {
      if (inserted || y[1] < x[0]) ans.Add(y);
      else if (y[0] > x[1])
      {
        ans.Add(x);
        ans.Add(y);
        inserted = true;
      }
      else if ((x[0] <= y[0] && y[0] <= x[1]) || (y[0] <= x[0] && x[0] <= y[1]))
      {
        x = new int[] { Math.Min(x[0], y[0]), Math.Max(x[1], y[1]) };
      }
    }
    if (!inserted) ans.Add(x);
    return ans.ToArray();
  }

  /*
  public int[][] Insert(int[][] intervals, int[] newInterval)
  {
    if (intervals.Length < 1) return new int[][] { newInterval };
    List<int[]> result = new List<int[]>();
    int n0 = newInterval[0];
    int n1 = newInterval[1];
    for (int i = 0; i < intervals.Length; i++)
    {
      int i0 = intervals[i][0];
      int i1 = intervals[i][1];
      if (n0 < 0) result.Add(intervals[i]);
      else if ((i0 <= n0 && n0 <= i1) || (n0 <= i0 && i0 <= n1))
      {
        n0 = Math.Min(n0, i0);
        n1 = Math.Max(n1, i1);
      }
      else if (n0 > i1)
      {
        result.Add(intervals[i]);
      }
      else
      {
        result.Add(new int[] { n0, n1 });
        result.Add(intervals[i]);
        n0 = -1;
      }
    }
    if (n0 >= 0) result.Add(new int[] { n0, n1 });
    return result.ToArray();
  }
  */
}