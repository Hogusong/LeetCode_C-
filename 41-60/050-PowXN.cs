public class Solution
{
  public double MyPow(double x, int n)
  {
    if (x == 0) return 0;
    Dictionary<int, double> dict = new Dictionary<int, double>();
    return n < 0 ? GetPower(1 / x, -n, dict) : GetPower(x, n, dict);
  }

  public double GetPower(double x, int n, Dictionary<int, double> dict)
  {
    if (n == 0) return 1;
    if (n == 1) return x;
    int k = n / 2;
    if (!dict.ContainsKey(k)) dict[k] = GetPower(x, k, dict);
    if (n % 2 == 0) return dict[k] * dict[k];
    return x * dict[k] * dict[k];
  }
}