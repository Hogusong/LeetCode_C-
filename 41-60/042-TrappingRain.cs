public class Solution
{
  public int Trap(int[] height)
  {
    int len = height.Length;
    int maxH = 0;
    int keyH = 0;
    int upArea = 0;
    int downArea = 0;
    int totalH = 0;
    for (int i = 0; i < len; i++)
    {
      totalH += height[i];
      maxH = Math.Max(maxH, height[i]);
      if (height[i] < keyH) upArea += keyH - height[i];
      else keyH = height[i];
    }
    keyH = 0;
    for (int i = len - 1; i >= 0; i--)
    {
      if (height[i] < keyH) downArea += keyH - height[i];
      else keyH = height[i];
    }
    int boxArea = maxH * len;
    return upArea + downArea + totalH - boxArea;
  }
}
