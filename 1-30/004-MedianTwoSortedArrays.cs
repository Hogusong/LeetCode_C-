public class Solution
{
  public double FindMedianSortedArrays(int[] nums1, int[] nums2)
  {
    int m = nums1.Length;
    int n = nums2.Length;
    bool isEven = (m + n) % 2 == 0;
    int mid = (m + n) / 2;
    int i = 0, j = 0, prev = 0, val = 0, count = 0;
    while ((i < m || j < n) && count <= mid)
    {
      count++;
      prev = val;
      if (i >= m) val = nums2[j++];
      else if (j >= n) val = nums1[i++];
      else val = (nums1[i] < nums2[j]) ? nums1[i++] : nums2[j++];
    }
    return isEven ? (double)(prev + val) / 2 : val;
  }
}