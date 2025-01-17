using System.Runtime.InteropServices.JavaScript;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    //Test 1
    // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue
    // Expected Result: jim (Pri:10), John (Pri:1), Kyle (Pri:10)
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("jim", 10);
        priorityQueue.Enqueue("John", 1);
        priorityQueue.Enqueue("Kyle", 10);
        Console.WriteLine(priorityQueue);
        Assert.AreEqual("[jim (Pri:10), John (Pri:1), Kyle (Pri:10)]", priorityQueue.ToString());

    }

    [TestMethod]
    //Test 2
    // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
    // Expected Result: kyle, john, jim, joe, paul, joseph
    // Defect(s) Found: Not returning the items in the correct order
    public void TestPriorityQueue_2()
    {
        Console.WriteLine("Test 2");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("jim", 5);
        priorityQueue.Enqueue("john", 4);
        priorityQueue.Enqueue("kyle", 6);
        priorityQueue.Enqueue("joe", 2);
        priorityQueue.Enqueue("paul", 1);
        priorityQueue.Enqueue("joseph", 3);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Assert.AreEqual("[jim (Pri:5), john (Pri:4), kyle (Pri:6), joe (Pri:2), paul (Pri:1), joseph (Pri:3)]", priorityQueue.ToString());
    }

    // Add more test cases as needed below.
    [TestMethod]
    //Test 3
    // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
    // Expected Result: kyle, joe, jim, john, joseph, paul
    // Defect(s) Found: Not returning the items in the correct order
    public void TestPriorityQueue_3()
    {
        Console.WriteLine("Test 3");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("jim", 5);
        priorityQueue.Enqueue("john", 4);
        priorityQueue.Enqueue("kyle", 6);
        priorityQueue.Enqueue("joe", 6);
        priorityQueue.Enqueue("paul", 1);
        priorityQueue.Enqueue("joseph", 3);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Assert.AreEqual("[jim (Pri:5), john (Pri:4), kyle (Pri:6), joe (Pri:6), paul (Pri:1), joseph (Pri:3)]", priorityQueue.ToString());
    }

    [TestMethod]
    //Test 4
    // Scenario: If the queue is empty, then an error exception shall be thrown.
    // Expected Result: InvalidOperationException
    // Defect(s) Found: Not throwing an exception when the queue is empty
    public void TestPriorityQueue_4()
    {
        Console.WriteLine("Test 4");
        var priorityQueue = new PriorityQueue();
        try
        {
            Console.WriteLine(priorityQueue.Dequeue());
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
    }

}