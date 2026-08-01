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
    public ListNode mergeTwoLists(ListNode list1, ListNode list2) {
        ListNode l1=list1;
        ListNode l2=list2;
        ListNode l3=new ListNode(-1);
        ListNode tail=l3;
        while(l1!=null && l2!=null )
        {
            if(l1.val<l2.val)
            {
                tail.next=l1;
                l1=l1.next;
            
            }
            else
            {
                tail.next=l2;
                l2=l2.next;
            }
            tail=tail.next;
           
        }
        if(l1!=null)
        {
           tail.next=l1;
            //l1=l1.next;
        }
        if(l2!=null)
        {
           tail.next=l2;
           /// l2=l2.next;
        }
        return l3.next;
    }
}