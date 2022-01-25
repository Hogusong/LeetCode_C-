public class Solution
{
  public int[][] Merge(int[][] intervals)
  {
    if (intervals.Length == 1) return intervals;
    List<int[]> list = new List<int[]>(intervals);
    List<int[]> ans = new List<int[]>();
    list.Sort((a, b) => (a[0] - b[0]));
    int[] temp = list[0];
    for (int i = 1; i < list.Count; i++)
    {
      if (temp[0] <= list[i][0] && list[i][0] <= temp[1])
      {
        temp[1] = Math.Max(temp[1], list[i][1]);
      }
      else
      {
        ans.Add(temp);
        temp = list[i];
      }
    }
    ans.Add(temp);
    return ans.ToArray();
  }

  /*
  public int[][] Merge(int[][] intervals)
  {
    if (intervals.Length < 2) return intervals;
    List<int[]> list = new List<int[]>(intervals);
    list.Sort((a, b) => (a[0] - b[0]));
    return MergeList(list);
  }

  public int[][] MergeList(List<int[]> intervals)
  {
    List<int[]> result = new List<int[]>();
    int[] temp = intervals[0];
    for (int i = 1; i < intervals.Count; i++)
    {
      int t0 = temp[0];
      int t1 = temp[1];
      int i0 = intervals[i][0];
      int i1 = intervals[i][1];
      if (i0 > t1)
      {
        result.Add(temp);
        temp = intervals[i];
      }
      else
      {
        temp[1] = Math.Max(t1, i1);
      }
    }
    result.Add(temp);
    return result.ToArray();
  }
  */

  /*
  public int[][] Merge(int[][] intervals)
  {
    if (intervals.Length < 2) return intervals;
    int[][] newIntervals = GetSortedIntervals(intervals);
    return MergeIntervals(newIntervals);
  }

  public int[][] MergeIntervals(int[][] intervals)
  {
    List<int[]> result = new List<int[]>();
    int[] temp = intervals[0];
    for (int i = 1; i < intervals.Length; i++)
    {
      int t0 = temp[0];
      int t1 = temp[1];
      int i0 = intervals[i][0];
      int i1 = intervals[i][1];
      if (t1 < i0)
      {
        result.Add(temp);
        temp = intervals[i];
      }
      else
      {
        temp[1] = Math.Max(t1, i1);
      }
    }
    result.Add(temp);
    return result.ToArray();
  }

  public int[][] GetSortedIntervals(int[][] intervals)
  {
    Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
    foreach (int[] n in intervals)
    {
      if (!dict.ContainsKey(n[0])) dict[n[0]] = new List<int>();
      dict[n[0]].Add(n[1]);
    }
    int[] keys = (new List<int>(dict.Keys)).ToArray();
    Array.Sort(keys);
    int[][] result = new int[keys.Length][];
    int i = 0;
    foreach (int k in keys)
    {
      int[] temp = dict[k].ToArray();
      Array.Sort(temp);
      result[i++] = new int[] { k, temp[temp.Length - 1] };
    }
    return result;
  }
  */
}