/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */

class Solution {
    public ListNode removeNthFromEnd(ListNode head, int n) {
        ListNode dummy=new ListNode(0);
        dummy.next=head;
        ListNode temp=head,current=head;
        int count=0;
        while(temp!=null)
        {
            temp=temp.next;
            count++;

        }
        count=count-n;
        current=dummy;
        for(int i=0;i<count;i++)
        {
            current=current.next;
        }
        current.next=current.next.next;
        return dummy.next;
    }
}
