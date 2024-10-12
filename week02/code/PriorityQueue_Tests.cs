using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adding different items with different priorities to check if they're added correctly 
    // Expected Result: [b (Pri:1), a (Pri:1), d (Pri:2), c (Pri:2), f (Pri:3), e (Pri:3)]
    // Defect(s) Found: The items were not adding correctly as the requirements demanded, so I had to rebuild the logic in the functions
    public void TestPriorityQueue_1()
    {
        String testResult = "[b (Pri:1), a (Pri:1), d (Pri:2), c (Pri:2), f (Pri:3), e (Pri:3)]";

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("a", 1);
        priorityQueue.Enqueue("b", 1);
        priorityQueue.Enqueue("c", 2);
        priorityQueue.Enqueue("d", 2);
        priorityQueue.Enqueue("e", 3);
        priorityQueue.Enqueue("f", 3);
        Assert.AreEqual(priorityQueue.ToString(), testResult);
    }

    [TestMethod]
    // Scenario: Adding items, and removing from the queue based on the requirements
    // Expected Result: [b (Pri:1), a (Pri:1), d (Pri:2)]
    // Defect(s) Found: The Dequeue function was not working properly, so I had to rewrite the logic
    public void TestPriorityQueue_2()
    {

        String testResult = "[b (Pri:1), a (Pri:1), d (Pri:2)]";

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("a", 1);
        priorityQueue.Enqueue("b", 1);
        priorityQueue.Enqueue("c", 2);
        priorityQueue.Enqueue("d", 2);
        priorityQueue.Enqueue("e", 3);
        priorityQueue.Enqueue("f", 3);
        
        String value = priorityQueue.Dequeue();
        value = priorityQueue.Dequeue();
        value = priorityQueue.Dequeue();
        
        Assert.AreEqual(priorityQueue.ToString(), testResult);
    }

    [TestMethod]
    // Scenario: Trying to dequeue from an empty list
    // Expected Result: Error should be thrown
    // Defect(s) Found: It worked as expected
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("a", 1);
        priorityQueue.Enqueue("b", 1);
        priorityQueue.Enqueue("c", 2);
        priorityQueue.Enqueue("d", 2);
        priorityQueue.Enqueue("e", 3);
        priorityQueue.Enqueue("f", 3);
        
        String value = priorityQueue.Dequeue();
        value = priorityQueue.Dequeue();
        value = priorityQueue.Dequeue();
        value = priorityQueue.Dequeue();
        value = priorityQueue.Dequeue();
        value = priorityQueue.Dequeue();
        value = priorityQueue.Dequeue();

        //trying to dequeue from an empty queue
        value = priorityQueue.Dequeue();
        
        
    }
}