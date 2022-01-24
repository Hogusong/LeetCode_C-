public class Solution
{
  public string IntToRoman(int num)
  {
    int[] values = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
    string[] romans = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
    string ans = "";
    int i = values.Length - 1;
    while (num > 0 && i >= 0)
    {
      int n = num / values[i];
      if (n > 0)
      {
        for (int j = 0; j < n; j++) ans = ans + romans[i];
        num = num - (values[i] * n);
      }
      i--;
    }
    return ans;
  }
}