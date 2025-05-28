namespace CsharpExercises.LeetCode;

internal static class LeetCode_AddTwoNumbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    private static void LinkNodes(List<ListNode> list)
    {
        for (var i = 0; i < list.Count - 1; i++)
            list[i].next = list[i + 1];
    }

    internal static ListNode Start()
    {
        var list1 = new List<ListNode>()
        {
            new ListNode(9),
            new ListNode(9),
            new ListNode(9),
            new ListNode(9),
            new ListNode(9),
            new ListNode(9),
            new ListNode(9)
        };

        LinkNodes(list1);

        var list2 = new List<ListNode>()
        {
            new ListNode(9),
            new ListNode(9),
            new ListNode(9),
            new ListNode(9),
        };

        ListNode head = null;
        ListNode firstHead = null;
        var carry = 0;
        var l1 = list1[0];
        var l2 = list2[0];

        do
        {
            var val1 = l1?.val ?? 0;
            var val2 = l2?.val ?? 0;

            var sum = val1 + val2 + carry;

            var digit = sum % 10;

            var newNode = new ListNode(digit);
            if (head != null) 
                head.next = newNode;
            else
                firstHead = newNode;

            head = newNode;

            carry = sum / 10;

            l1 = l1?.next;
            l2 = l2?.next;
        } while (l1 != null || l2 != null || carry != 0);

        return firstHead;
    }
}