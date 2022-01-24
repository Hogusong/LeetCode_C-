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
  public ListNode ReverseKGroup(ListNode head, int k)
  {
    ListNode root = new ListNode(0, head);
    ListNode prev = root, kthNode = head;
    while (kthNode != null)
    {
      int i = 0;
      while (i < k && kthNode != null)
      {
        kthNode = kthNode.next;
        i++;
      }
      if (i < k) break;
      i = 1;
      ListNode curr = prev.next, second = curr.next;
      while (i < k)
      {
        curr.next = second.next;
        second.next = prev.next;
        prev.next = second;
        second = curr.next;
        i++;
      }
      prev = curr;
    }
    return root.next;
  }

  /*
  public ListNode ReverseKGroup(ListNode head, int k)
  {
    ListNode root = new ListNode(0, head);
    ListNode prev = root;
    ListNode curr = head;
    int reverseCount = 0;
    while (curr != null)
    {
      curr = curr.next;
      reverseCount++;
    }
    reverseCount = reverseCount / k;
    while (reverseCount > 0)
    {
      int count = 0;
      curr = prev.next;
      ListNode movingNode = curr.next;
      while (count < k - 1)
      {
        curr.next = movingNode.next;
        movingNode.next = prev.next;
        prev.next = movingNode;
        movingNode = curr.next;
        count++;
      }
      prev = curr;
      reverseCount--;
    }
    return root.next;
  }
  */
}