
public class Solution
{
  public string Convert(string s, int numRows)
  {
    if (numRows == 1) return s;
    int keyNum = (numRows - 1) * 2;
    string[] output = new string[numRows];
    for (int i = 0; i < numRows; i++) output[i] = "";
    for (int i = 0; i < s.Length; i++)
    {
      int r = i % keyNum;
      if (r > numRows - 1) r = keyNum - r;
      output[r] = output[r] + s[i];
    }
    return string.Join("", output);
  }
}