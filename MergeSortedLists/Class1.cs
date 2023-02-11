namespace MergeSortedLists;

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
public class Class1
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode result = new ListNode();
        List<int> mergeList = new List<int>();
        if (list1 == null && list2 == null)
        {
            return null;
        }
        while (list1 != null || list2 != null)
        {
            if (list1 != null)
            {
                mergeList.Add(list1.val);
                list1 = list1.next;
            }
            if (list2 != null)
            {
                mergeList.Add(list2.val);
                list2 = list2.next;
            }
        }
        foreach (int num in mergeList.OrderBy(x => -x))
        {
            if (result.val == 0 && result.next == null)
            {
                result = new ListNode(num, null);
            }
            else
            {
                result = new ListNode(num, result);
            }
        }
        return result;
    }
}
