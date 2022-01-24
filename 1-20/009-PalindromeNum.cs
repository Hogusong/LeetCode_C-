public class Solution
{
  public bool IsPalindrome(int x)
  {
    if (x < 0) return false;
    int ans = 0;
    int z = x;
    while (z > 0)
    {
      int remain = z % 10;
      ans = ans * 10 + remain;
      z = z / 10;
    }
    return ans == x;
  }
}