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
  public ListNode RemoveNthFromEnd(ListNode head, int n)
  {
    ListNode root = new ListNode(0, head);
    ListNode curr = root, nthNode = head;
    while (n > 0)
    {
      n--;
      nthNode = nthNode.next;
    }
    while (nthNode != null)
    {
      curr = curr.next;
      nthNode = nthNode.next;
    }
    curr.next = curr.next.next;
    return root.next;
  }

  /*
  public ListNode RemoveNthFromEnd(ListNode head, int n)
  {
    if (head.next == null && n == 1) return null;
    ListNode curr = head, nthNode = head;
    int count = 0;
    while (curr != null)
    {
      count++;
      curr = curr.next;
    }
    n = n % count;
    if (n == 0) return head.next;
    while (n > 0)
    {
      n--;
      nthNode = nthNode.next;
    }
    curr = head;
    while (nthNode.next != null)
    {
      curr = curr.next;
      nthNode = nthNode.next;
    }
    curr.next = curr.next.next;
    return head;
  }
  */
}