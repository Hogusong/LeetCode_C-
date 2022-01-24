public class Solution
{
  public int Reverse(int x)
  {
    double ans = 0;
    int prefix = x < 0 ? -1 : 1;
    x = prefix * x;
    while (x > 0)
    {
      int remain = x % 10;
      ans = ans * 10 + remain;
      x = x / 10;
    }
    ans = ans * prefix;
    if (ans < int.MinValue || ans > int.MaxValue) return 0;
    return (int)ans;
  }
}