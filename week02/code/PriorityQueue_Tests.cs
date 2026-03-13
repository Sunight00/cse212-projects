using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:  Add 4 items with different priorities to the queue and remove one item.
    // Expected Result: The item with the highest priority ("Highest Priority") is removed first.
    // Defect(s) Found: Before fixing, the Dequeue method did not remove the item from the queue; 
    // The commented out loop had a defect of return the last item with the highest priority instead of the first one(in this case 10 because the loop was cut short using index starting from 1 and subtracting the total number of item in queue from 4 to 3). 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low Priority", 1);
        priorityQueue.Enqueue("Medium Priority", 5);
        priorityQueue.Enqueue("High Priority", 10);
        priorityQueue.Enqueue("Highest Priority", 20);
        Assert.AreEqual("Highest Priority", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Added multiple items with the same high priority and remove one item.
    // Expected Result: The first item with the highest priority (following FIFO) is removed first.
    // Defect(s) Found: Before fixing, the Dequeue method returned the wrong item when multiple items shared the highest priority.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
           
        priorityQueue.Enqueue("First High", 10);
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Second High", 10);

        // The first high-priority item should be dequeued first
        Assert.AreEqual("First High", priorityQueue.Dequeue());

        // Next high-priority item should be dequeued next
        Assert.AreEqual("Second High", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}