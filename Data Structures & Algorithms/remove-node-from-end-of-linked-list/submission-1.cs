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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode prev = null;
        ListNode evil = head;
        ListNode helper = evil;
        while(helper != null){
            for(int i = 0 ; i < n ;i++){
                helper = helper.next;
            } 
            if(helper == null)
                break;
            prev = evil;
            evil = evil.next;
            helper = evil;
        }
        if(prev != null){
            prev.next = evil.next;
        }
        else{
            return head.next;
        }


        return head;
    }
}
