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
        // Step 1: Create a new double array with the size equal to lenght
        // Step 2: Create a for loop that goes from 0 to length -1
        // Step 3: In each position 'i', place 'number * (i + 1)'
        // Step 4: Return the filled array
    
        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
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
        // Step 1: Check how many elements there are in total (data.Count)
        // Step 2: Split the last 'amount' elements using GetRange
        // Step 3: Split the remaining elements (from the beginning to Count - amount)
        // Step 4: Clear the original list using Clear()
        // Step 5: Add the two chunks back, first the end, then the beginning

        int n = data.Count;
        List<int> endPart = data.GetRange(n - amount, amount);
        List<int> startPart = data.GetRange(0, n - amount);
        data.Clear();

        data.AddRange(endPart);
        data.AddRange(startPart);
    }
}
