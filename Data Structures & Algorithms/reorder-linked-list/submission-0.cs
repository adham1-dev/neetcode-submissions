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

public class Solution {
    public void ReorderList(ListNode head) {
               if(head?.next == null){
            return;
        }


        ListNode slow = head;
        ListNode fast = head.next;
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode curr = slow.next;
        slow.next = null;

        ListNode prev = null;
        while(curr!= null){
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;

            curr = temp;
        }

        ListNode firstPart = head;
        ListNode lastPart = prev;

        while(lastPart != null){
            ListNode temp1 = firstPart.next;
            ListNode temp2 = lastPart.next;
            firstPart.next = lastPart;
            lastPart.next = temp1;
            firstPart = temp1;
            lastPart = temp2;
        }

    }
}
