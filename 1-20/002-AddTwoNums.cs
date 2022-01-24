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
  public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
  {
    ListNode head = null, curr = null, node = null;
    int up = 0, n = 0;
    while (l1 != null || l2 != null)
    {
      if (l1 == null)
      {
        n = up + l2.val;
        l2 = l2.next;
      }
      else if (l2 == null)
      {
        n = up + l1.val;
        l1 = l1.next;
      }
      else
      {
        n = up + l1.val + l2.val;
        l1 = l1.next;
        l2 = l2.next;
      }
      up = n > 9 ? 1 : 0;
      node = new ListNode(n % 10);
      if (head == null)
      {
        head = node;
        curr = head;
      }
      else
      {
        curr.next = node;
        curr = curr.next;
      }
    }
    if (up > 0) curr.next = new ListNode(1);
    return head;
  }
}