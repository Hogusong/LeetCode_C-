public class Solution
{
  public string GetPermutation(int n, int k)
  {
    Dictionary<int, int> fact = new Dictionary<int, int>();
    Factorial(n, fact);
    List<int> list = new List<int>();
    for (int i = 1; i <= n; i++) list.Add(i);
    string ans = "";
    for (int i = 1; i <= n; i++)
    {
      if (k <= 1)
      {
        foreach (int x in list) ans += x;
        break;
      }
      int index = k / fact[n - i];
      if (k % fact[n - i] == 0) index--;
      ans += list[index];
      list.RemoveAt(index);
      k = k - fact[n - i] * index;
    }
    return ans;
  }

  public int Factorial(int n, Dictionary<int, int> fact)
  {
    if (n == 1) return 1;
    if (!fact.ContainsKey(n - 1)) fact[n - 1] = Factorial(n - 1, fact);
    return n * fact[n - 1];
  }
}