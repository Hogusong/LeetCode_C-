public class Solution
{
  public int Divide(int dividend, int divisor)
  {
    double count = 1;
    double ans = 0;
    int prefix = 1;
    double ddividend = (double)dividend;
    double ddivisor = (double)divisor;
    if (ddividend < 0)
    {
      prefix = -1;
      ddividend *= -1;
    }
    if (ddivisor < 0)
    {
      prefix *= -1;
      ddivisor *= -1;
    }
    double div = ddivisor;
    while (ddividend >= ddivisor)
    {
      if (div > ddividend)
      {
        div = ddivisor;
        count = 1;
      }
      else
      {
        ddividend -= div;
        ans += count;
        div += div;
        count += count;
        if (ans * prefix > int.MaxValue) return int.MaxValue;
        if (ans * prefix < int.MinValue) return int.MinValue;
      }
    }
    return prefix * (int)ans;
  }

  /*
  public int Divide(int dividend, int divisor)
  {
    if (dividend == 0) return 0;
    bool isNegative = (dividend < 0 && divisor > 0) || (dividend > 0 && divisor < 0);
    double x = Math.Abs((double)dividend);
    double y = Math.Abs((double)divisor);
    double z = y, count = 1;
    double ans = 0;
    while (x >= y)
    {
      if (x < z)
      {
        z = y;
        count = 1;
      }
      else
      {
        x -= z;
        ans += count;
        count = count + count;
        z = z + z;
      }
    }
    if (isNegative) ans = ans * -1;
    if (ans < int.MinValue) return int.MinValue;
    if (ans > int.MaxValue) return int.MaxValue;
    return (int)ans;
  }
  */
}