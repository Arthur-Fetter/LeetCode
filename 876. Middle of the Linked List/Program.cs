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
    public ListNode MiddleNode(ListNode head) {
        // Get node count
        ListNode currentNode = head;
        int node_count = 0;

        while (currentNode != null)
        {
            node_count++;
            currentNode = currentNode.next;
        }

        int middle_index = (node_count / 2);

        currentNode = head;
        ListNode finalList = null;

        node_count = 0;
        while (currentNode != null)
        {
            if (node_count >= middle_index)
            {
                finalList = currentNode;
                break;
            }

            currentNode = currentNode.next;
            node_count++;
        }

        return finalList;
    }
}