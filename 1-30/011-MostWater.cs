public class Solution
{
  public int MaxArea(int[] height)
  {
    int maxA = 0;
    int l = 0;
    int r = height.Length - 1;
    int minH = 0;
    while (l < r)
    {
      if (height[l] > height[r])
      {
        minH = height[r--];
      }
      else
      {
        minH = height[l++];
      }
      maxA = Math.Max(maxA, minH * (r - l + 1));
    }
    return maxA;
  }
}