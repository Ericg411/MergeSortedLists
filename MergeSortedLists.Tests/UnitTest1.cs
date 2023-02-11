namespace MergeSortedLists.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4, null)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4, null)));

        var result = _test.MergeTwoLists(list1, list2);

        int total = 0;

        while (result != null)
        {
            total += result.val;
            result = result.next;
        }

        Assert.AreEqual(15, total);
    }

    [TestMethod]
    public void TestMethod2()
    {
        var list2 = new ListNode(0, null);

        var result = _test.MergeTwoLists(null, list2);

        int total = 0;

        while (result != null)
        {
            total += result.val;
            result = result.next;
        }

        Assert.AreEqual(0, total);
    }

    [TestMethod]
    public void TestMethod3()
    {
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4, new ListNode(7, new ListNode(9, null)))));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, null)))));

        var result = _test.MergeTwoLists(list1, list2);

        int total = 0;

        while (result != null)
        {
            total += result.val;
            result = result.next;
        }

        Assert.AreEqual(42, total);
    }
}