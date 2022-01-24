/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
  public ListNode MergeKLists(ListNode[] lists)
  {
    if (lists.Length < 1) return null;
    List<ListNode> ans = new List<ListNode>(lists);
    while (ans.Count > 1)
    {
      List<ListNode> temp = ans;
      ans = new List<ListNode>();
      int l = 0;
      int r = temp.Count - 1;
      while (l <= r)
      {
        if (l == r) ans.Add(temp[l]);
        else
        {
          ListNode merged = MergeTwo(temp[l], temp[r]);
          ans.Add(merged);
        }
        l++;
        r--;
      }
    }
    return ans[0];
  }

  public ListNode MergeTwo(ListNode A, ListNode B)
  {
    ListNode root = new ListNode(0);
    ListNode curr = root;
    while (A != null && B != null)
    {
      if (A.val > B.val)
      {
        curr.next = B;
        B = B.next;
      }
      else
      {
        curr.next = A;
        A = A.next;
      }
      curr = curr.next;
    }
    curr.next = A != null ? A : B;
    return root.next;
  }

  /*
  public ListNode MergeKLists(ListNode[] lists)
  {
    if (lists.Length < 1) return null;
    return MergeLists(lists, 0, lists.Length - 1);
  }

  public ListNode MergeLists(ListNode[] lists, int from, int to)
  {
    if (from >= to) return lists[from];
    int mid = (from + to) / 2;
    ListNode left = MergeLists(lists, from, mid);
    ListNode right = MergeLists(lists, mid + 1, to);
    return MergeTwo(left, right);
  }
  */
}
