public class Solution
{
  public int MyAtoi(string s)
  {
    double ans = 0;
    bool digitStarted = false;
    int prefix = 1;
    int i = 0;
    while (i < s.Length)
    {
      if (s[i] == ' ')
      {
        if (digitStarted)
        {
          i = s.Length;
        }
      }
      else if (s[i] == '+')
      {
        if (digitStarted) i = s.Length;
        else digitStarted = true;
      }
      else if (s[i] == '-')
      {
        if (digitStarted) i = s.Length;
        else
        {
          prefix = -1;
          digitStarted = true;
        }
      }
      else if ("0123456789".Contains(s[i]))
      {
        ans = ans * 10 + (s[i] - '0');
        digitStarted = true;
      }
      else
      {
        i = s.Length;
      }
      i++;
    }
    ans = ans * prefix;
    if (ans >= int.MaxValue) return int.MaxValue;
    if (ans <= int.MinValue) return int.MinValue;
    return Convert.ToInt32(ans);
  }

  /*
  public int MyAtoi(string s)
  {
    s = s.Trim();
    string nums = "0123456789";
    double ans = 0, prefix = 1;
    for (int i = 0; i < s.Length; i++)
    {
      if (nums.Contains(s[i]))
      {
        ans = ans * 10 + (s[i] - '0');
      }
      else if (i == 0 && s[i] == '-') prefix = -1;
      else if (i == 0 && s[i] == '+') continue;
      else break;
    }
    ans = ans * prefix;
    if (ans < int.MinValue) return int.MinValue;
    return ans > int.MaxValue ? int.MaxValue : (int)ans;
  }
  */
}