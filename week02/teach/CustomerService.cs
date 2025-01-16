/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService
{
    public static void Run()
    {
        // Example code to see what's in the customer service queue:
        
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: if max size is <+ 0
        // Expected Result: max size reverts to 10
        Console.WriteLine("Test 1");
        var cs = new CustomerService(-1);
        Console.WriteLine(cs);

        // Defect(s) Found: No Defect

        Console.WriteLine("=================");

        // Test 2
        // Scenario: The AddNewCustomer method shall enqueue a new customer into the queue.
        // Expected Result: Customer added successfully.
        Console.WriteLine("Test 2");
        cs.AddNewCustomer();
        cs.AddNewCustomer();
        Console.WriteLine(cs);

        // Defect(s) Found: No defect found.

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
        // Test 3  
        // Scenario: the queue is full and a new customer is added
        // expected result: error message displayed
        Console.WriteLine("Test 3");
        var customerServiceTest3 = new CustomerService(1);
        customerServiceTest3.AddNewCustomer();
        customerServiceTest3.AddNewCustomer();
        customerServiceTest3.AddNewCustomer();
        Console.WriteLine(customerServiceTest3);

        // Defect(s) Found: the program let me add an extra person to the queue before showing an error



        // Test 4
        // Scenario: Removing a customer from the queue
        // Expected Result: Removes a customer from the queue if there is one or prints "No Customers in queue"
        // Defect(s) Found: 2
        Console.WriteLine("\nTest 4");

        // Initialize the Service
        CustomerService customerService = new(4);

        // Test Remove from queue with empty queue
        Console.WriteLine("Expected:  No Customers in the queue");
        Console.Write("Actual: ");
        customerService.ServeCustomer();

        // Add a customer
        Console.WriteLine();
        customerService.AddNewCustomer();


        // Test Remove from queue with one customer
        Console.WriteLine("\nExpected: This should display the customer that was added");
        Console.Write("Actual: ");
        customerService.ServeCustomer();

        // Finish Test 4
        Console.WriteLine(new string('=', 17));
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize)
    {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize - 1;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer
    {
        public Customer(string name, string accountId, string problem)
        {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString()
        {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer()
    {
        // Verify there is room in the service queue
        if (_queue.Count > _maxSize)
        {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer()
    {
        if (_queue.Count <= 0)
{
    Console.WriteLine("No Customers in the queue");
}
else
{
    //! Collect customer information and then remove them from queue
    var customer = _queue[0];
    _queue.RemoveAt(0);
    Console.WriteLine(customer);
}
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString()
    {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}