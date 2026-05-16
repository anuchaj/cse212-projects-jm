public static class Arrays
{
    /// <summary> Joseph Anucha
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Problem Solving Plan:
        // 1. Create a new array with the required length.
        // 2. Use a loop to go through each index in the array.
        // 3. For each position, calculate the multiple of the number.
        //    The first value should be number * 1.
        //    The second value should be number * 2.
        //    Continue until the array is full.
        // 4. Store each calculated value into the array.
        // 5. Return the completed array.

        double[] results = new double[length];

        for (int i = 0; i < length; i++)
        {
            results[i] = number * (i + 1);
        }

        return results;
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
        // Problem Solving Plan:
        // 1. Determine where the split point should be.
        //    The split point is data.Count - amount.
        //
        // 2. Create a list containing the values that will move
        //    to the front of the list.
        //    Example:
        //    If amount = 3 and list is:
        //    {1,2,3,4,5,6,7,8,9}
        //    then take:
        //    {7,8,9}
        //
        // 3. Remove those values from the original list.
        //
        // 4. Insert the saved values at the beginning of the list.
        //
        // 5. The original list is now rotated correctly.

        int splitIndex = data.Count - amount;

        List<int> movedItems = data.GetRange(splitIndex, amount);

        data.RemoveRange(splitIndex, amount);

        data.InsertRange(0, movedItems);
    }
}
