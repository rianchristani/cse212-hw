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

        //1. Create an new array of doubles with the size of 'length'.
        var numbers = new double[length];

        //2. Create a for loop that will go trough the array
        for (int i = 0; i < length; i++)
        {
            //3 and 4. In each iteration, calculate the multiple of 'number' by multiplying it with (i + 1) and assign it to the current index of the array.
            numbers[i] = number * (i + 1);
        }

        //5. Return the array.
        return numbers; // replace this return statement with your own
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

        //1. Determine the index where the rotation will start.
        int index = data.Count - amount;

        //2. Copy the elements that will be rotated to a temporary list.
        var finalPart = data.GetRange(index, amount);

        //3. Recomve the elements that will be rotated from the original list.
        data.RemoveRange(index, amount);

        //4. Insert the temporary list at the beginning of the original list.
        data.InsertRange(0, finalPart);
    }
}
