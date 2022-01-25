public class Solution
{
  public string CountAndSay(int n)
  {
    string ans = "1";
    for (int i = 0; i < n - 1; i++)
    {
      string temp = ans;
      ans = "";
      char prev = temp[0];
      int count = 1;
      for (int j = 1; j < temp.Length; j++)
      {
        if (prev == temp[j]) count++;
        else
        {
          ans = ans + Convert.ToString(count) + Convert.ToString(prev);
          prev = temp[j];
          count = 1;
        }
      }
      ans = ans + Convert.ToString(count) + Convert.ToString(prev);
    }
    return ans;
  }
}