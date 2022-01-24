public class Solution
{
  public bool IsValid(string s)
  {
    if (s.Length % 2 == 1) return false;
    Stack<char> stack = new Stack<char>();
    foreach (char c in s)
    {
      if ("({[".Contains(c.ToString())) stack.Push(c);
      else
      {
        if (stack.Count < 1) return false;
        char cha = stack.Pop();
        if (c == ')' && cha != '(') return false;
        if (c == ']' && cha != '[') return false;
        if (c == '}' && cha != '{') return false;
      }
    }
    return stack.Count == 0;
  }
}