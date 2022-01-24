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
  public ListNode MergeTwoLists(ListNode list1, ListNode list2)
  {
    if (list1 == null) return list2;
    if (list2 == null) return list1;
    ListNode root = new ListNode(0);
    ListNode curr = root;
    while (list1 != null && list2 != null)
    {
      if (list1.val > list2.val)
      {
        curr.next = list2;
        list2 = list2.next;
      }
      else
      {
        curr.next = list1;
        list1 = list1.next;
      }
      curr = curr.next;
    }
    curr.next = list1 == null ? list2 : list1;
    return root.next;
  }
}