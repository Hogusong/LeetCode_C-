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
  public ListNode SwapPairs(ListNode head)
  {
    if (head == null || head.next == null) return head;
    ListNode root = new ListNode(0, head);
    ListNode prev = root, first = head, second = head.next;
    while (first != null && first.next != null)
    {
      first.next = second.next;
      second.next = first;
      prev.next = second;

      prev = first;
      first = first.next;
      second = first != null ? first.next : null;
    }
    return root.next;
  }
}