using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:
    // Add three items with different priorities.
    // Expected Result:
    // Items should be removed in highest priority order.
    // Defect(s) Found:
    // Queue did not always remove the item with highest priority.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        Assert.AreEqual("Tim", priorityQueue.Dequeue());
        Assert.AreEqual("Sue", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario:
    // Add multiple items with the same highest priority.
    // Expected Result:
    // Items with same priority should follow FIFO order.
    // Defect(s) Found:
    // Queue did not preserve FIFO order for equal priorities.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Tim", priorityQueue.Dequeue());
        Assert.AreEqual("Sue", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario:
    // Attempt to dequeue from an empty queue.
    // Expected Result:
    // InvalidOperationException should be thrown with correct message.
    // Defect(s) Found:
    // Queue did not throw correct exception or message when empty.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                $"Unexpected exception of type {e.GetType()} caught: {e.Message}"
            );
        }
    }
}