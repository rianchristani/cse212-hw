using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item A", 5);
        priorityQueue.Enqueue("Item B", 10);
        priorityQueue.Enqueue("Item C", 3);

        string resultado = priorityQueue.Dequeue();
        Assert.AreEqual("Item B", resultado);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item A", 10);
        priorityQueue.Enqueue("Item B", 5);
        priorityQueue.Enqueue("Item C", 10);

        string resultado = priorityQueue.Dequeue();
        Assert.AreEqual("Item A", resultado);
    }

    // Add more test cases as needed below.
}