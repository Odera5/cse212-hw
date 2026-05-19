using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;

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



 // pseudo code:
 // step1. receive a list of numbers and an amount to rotate
 // step 2. find the index at which the rotate will start
 // step3. split the list at the found index
 // step4. get the end part of the list that will move to the front and get the begiining part of the lsit that will move behind
 // step5. clear the original list and rebuild it by adding the end part first begore the beginning part




 //code solution

 int splitindex = data.Count - amount; // step 2
 List<int> beginning = data.GetRange(0, splitindex); // step 4
 List<int> end = data.GetRange(splitindex, amount); // step 4
 data.Clear(); // step 5
 data.AddRange(end); // step 5
 data.AddRange(beginning); // step 5
    }
}
