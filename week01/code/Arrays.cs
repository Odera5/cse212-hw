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


        //Pseudo code:
        //1. create an array of double of specified length
        //2. use a for loop and loop length times
        //3. at each iteration calculate the multiple of a number and store it in the array
        //4. then retun the completed array.

        //Code solution

        var multiples = new double[length]; // step1
        for (int i = 0; i < length; i++)// step 2
        {
            multiples[i] = number * (i +1); //step 3
        }

        return multiples;
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


        // STEP 1:
    // Find where the list should be split.
    // Example:
    // If the list has 9 items and amount is 3,
    // then splitIndex = 9 - 3 = 6
    int splitIndex = data.Count - amount;

    // STEP 2:
    // Get the last part of the list that will move to the front.
    // Example: {7, 8, 9}
    List<int> endPart = data.GetRange(splitIndex, amount);

    // STEP 3:
    // Get the beginning part of the list.
    // Example: {1, 2, 3, 4, 5, 6}
    List<int> beginningPart = data.GetRange(0, splitIndex);

    // STEP 4:
    // Clear the original list so we can rebuild it.
    data.Clear();

    // STEP 5:
    // Add the end part first.
    data.AddRange(endPart);

    // STEP 6:
    // Add the beginning part after it.
    data.AddRange(beginningPart);

    }
}
