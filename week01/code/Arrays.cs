public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        var result = new double[length]; // create an array of doubles with the length of the input
        for (var i = 0; i < length; i++) // loop through the array length
        {
            result[i] = number * (i + 1); // set the value of the array at index i to the number X i + 1 
        }

        return result; // return the array
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        var count = data.Count; // get the count of the list
        var amountToRotate = amount % count; // amount to rotate is the amount modulo count (ex. if you want to rotate 10 times on a list of 5, you only need to rotate 5 times)
        
        data.InsertRange(0, data.GetRange(count - amountToRotate, amountToRotate)); // slice the list from the count - amount to the end and add it to the front of the list
        
        data.RemoveRange(count, amountToRotate); // remove the elements from the end of the list

    }
}
